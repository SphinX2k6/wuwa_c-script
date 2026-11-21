using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F8 RID: 1528
	[NetMessage(EMessageId.FlySkinAllUnLoadResponse)]
	public sealed class FlySkinAllUnLoadResponse : IMessage<FlySkinAllUnLoadResponse>, IMessage, IEquatable<FlySkinAllUnLoadResponse>, IDeepCloneable<FlySkinAllUnLoadResponse>, IBufferMessage
	{
		// Token: 0x06008DC4 RID: 36292 RVA: 0x001582E5 File Offset: 0x001564E5
		[NullableContext(1)]
		public static FlySkinAllUnLoadResponse Create()
		{
			return new FlySkinAllUnLoadResponse();
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06008DC5 RID: 36293 RVA: 0x001582EC File Offset: 0x001564EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x001582EF File Offset: 0x001564EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinAllUnLoadResponse.Descriptor;
			}
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x001582F6 File Offset: 0x001564F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadResponse()
		{
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x00158309 File Offset: 0x00156509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadResponse(FlySkinAllUnLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.unLoadSkinRoles_ = other.unLoadSkinRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x0015833F File Offset: 0x0015653F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadResponse Clone()
		{
			return new FlySkinAllUnLoadResponse(this);
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06008DCA RID: 36298 RVA: 0x00158347 File Offset: 0x00156547
		// (set) Token: 0x06008DCB RID: 36299 RVA: 0x0015834F File Offset: 0x0015654F
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

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06008DCC RID: 36300 RVA: 0x00158358 File Offset: 0x00156558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLoadSkinRoles
		{
			get
			{
				return this.unLoadSkinRoles_;
			}
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x00158360 File Offset: 0x00156560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinAllUnLoadResponse);
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x00158370 File Offset: 0x00156570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinAllUnLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.unLoadSkinRoles_.Equals(other.unLoadSkinRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DCF RID: 36303 RVA: 0x001583C0 File Offset: 0x001565C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.unLoadSkinRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x00158413 File Offset: 0x00156613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x00158420 File Offset: 0x00156620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x0015842C File Offset: 0x0015662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unLoadSkinRoles_.WriteTo(ref output, FlySkinAllUnLoadResponse._repeated_unLoadSkinRoles_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x0015847C File Offset: 0x0015667C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.unLoadSkinRoles_.CalculateSize(FlySkinAllUnLoadResponse._repeated_unLoadSkinRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x001584D0 File Offset: 0x001566D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinAllUnLoadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.unLoadSkinRoles_.Add(other.unLoadSkinRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x0015851D File Offset: 0x0015671D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x00158528 File Offset: 0x00156728
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
				if (num != 72U && num != 74U)
				{
					if (num != 96U)
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
					this.unLoadSkinRoles_.AddEntriesFrom(ref input, FlySkinAllUnLoadResponse._repeated_unLoadSkinRoles_codec);
				}
			}
		}

		// Token: 0x04004589 RID: 17801
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400458A RID: 17802
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400458B RID: 17803
		private ErrorCode errorCode_;

		// Token: 0x0400458C RID: 17804
		public const int UnLoadSkinRolesFieldNumber = 9;

		// Token: 0x0400458D RID: 17805
		private static readonly FieldCodec<int> _repeated_unLoadSkinRoles_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400458E RID: 17806
		private readonly RepeatedField<int> unLoadSkinRoles_ = new RepeatedField<int>();
	}
}
