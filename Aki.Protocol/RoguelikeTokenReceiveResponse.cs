using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB5 RID: 4021
	[NetMessage(EMessageId.RoguelikeTokenReceiveResponse)]
	public sealed class RoguelikeTokenReceiveResponse : IMessage<RoguelikeTokenReceiveResponse>, IMessage, IEquatable<RoguelikeTokenReceiveResponse>, IDeepCloneable<RoguelikeTokenReceiveResponse>, IBufferMessage
	{
		// Token: 0x06015869 RID: 88169 RVA: 0x00320778 File Offset: 0x0031E978
		[NullableContext(1)]
		public static RoguelikeTokenReceiveResponse Create()
		{
			return new RoguelikeTokenReceiveResponse();
		}

		// Token: 0x170047CC RID: 18380
		// (get) Token: 0x0601586A RID: 88170 RVA: 0x0032077F File Offset: 0x0031E97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047CD RID: 18381
		// (get) Token: 0x0601586B RID: 88171 RVA: 0x00320782 File Offset: 0x0031E982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTokenReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0601586C RID: 88172 RVA: 0x00320789 File Offset: 0x0031E989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveResponse()
		{
		}

		// Token: 0x0601586D RID: 88173 RVA: 0x0032079C File Offset: 0x0031E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveResponse(RoguelikeTokenReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601586E RID: 88174 RVA: 0x003207D2 File Offset: 0x0031E9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveResponse Clone()
		{
			return new RoguelikeTokenReceiveResponse(this);
		}

		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x0601586F RID: 88175 RVA: 0x003207DA File Offset: 0x0031E9DA
		// (set) Token: 0x06015870 RID: 88176 RVA: 0x003207E2 File Offset: 0x0031E9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x06015871 RID: 88177 RVA: 0x003207EB File Offset: 0x0031E9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x06015872 RID: 88178 RVA: 0x003207F3 File Offset: 0x0031E9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTokenReceiveResponse);
		}

		// Token: 0x06015873 RID: 88179 RVA: 0x00320804 File Offset: 0x0031EA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTokenReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015874 RID: 88180 RVA: 0x00320854 File Offset: 0x0031EA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015875 RID: 88181 RVA: 0x003208A7 File Offset: 0x0031EAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015876 RID: 88182 RVA: 0x003208B4 File Offset: 0x0031EAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015877 RID: 88183 RVA: 0x003208C0 File Offset: 0x0031EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, RoguelikeTokenReceiveResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015878 RID: 88184 RVA: 0x00320910 File Offset: 0x0031EB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(RoguelikeTokenReceiveResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015879 RID: 88185 RVA: 0x00320964 File Offset: 0x0031EB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTokenReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601587A RID: 88186 RVA: 0x003209B1 File Offset: 0x0031EBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601587B RID: 88187 RVA: 0x003209BC File Offset: 0x0031EBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 42U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, RoguelikeTokenReceiveResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x040081CC RID: 33228
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081CD RID: 33229
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040081CE RID: 33230
		private ErrorCode errorCode_;

		// Token: 0x040081CF RID: 33231
		public const int ItemMapFieldNumber = 5;

		// Token: 0x040081D0 RID: 33232
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040081D1 RID: 33233
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
