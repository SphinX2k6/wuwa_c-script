using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CF RID: 5071
	[NetMessage(EMessageId.TowerStartResponse)]
	public sealed class TowerStartResponse : IMessage<TowerStartResponse>, IMessage, IEquatable<TowerStartResponse>, IDeepCloneable<TowerStartResponse>, IBufferMessage
	{
		// Token: 0x0601AE51 RID: 110161 RVA: 0x003E608C File Offset: 0x003E428C
		[NullableContext(1)]
		public static TowerStartResponse Create()
		{
			return new TowerStartResponse();
		}

		// Token: 0x17005AB3 RID: 23219
		// (get) Token: 0x0601AE52 RID: 110162 RVA: 0x003E6093 File Offset: 0x003E4293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AB4 RID: 23220
		// (get) Token: 0x0601AE53 RID: 110163 RVA: 0x003E6096 File Offset: 0x003E4296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerStartResponse.Descriptor;
			}
		}

		// Token: 0x0601AE54 RID: 110164 RVA: 0x003E609D File Offset: 0x003E429D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartResponse()
		{
		}

		// Token: 0x0601AE55 RID: 110165 RVA: 0x003E60A5 File Offset: 0x003E42A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartResponse(TowerStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE56 RID: 110166 RVA: 0x003E60D6 File Offset: 0x003E42D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartResponse Clone()
		{
			return new TowerStartResponse(this);
		}

		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x0601AE57 RID: 110167 RVA: 0x003E60DE File Offset: 0x003E42DE
		// (set) Token: 0x0601AE58 RID: 110168 RVA: 0x003E60E6 File Offset: 0x003E42E6
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

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x0601AE59 RID: 110169 RVA: 0x003E60EF File Offset: 0x003E42EF
		// (set) Token: 0x0601AE5A RID: 110170 RVA: 0x003E60F7 File Offset: 0x003E42F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x0601AE5B RID: 110171 RVA: 0x003E6100 File Offset: 0x003E4300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerStartResponse);
		}

		// Token: 0x0601AE5C RID: 110172 RVA: 0x003E610E File Offset: 0x003E430E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE5D RID: 110173 RVA: 0x003E614C File Offset: 0x003E434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE5E RID: 110174 RVA: 0x003E61AA File Offset: 0x003E43AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE5F RID: 110175 RVA: 0x003E61B7 File Offset: 0x003E43B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE60 RID: 110176 RVA: 0x003E61C0 File Offset: 0x003E43C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE61 RID: 110177 RVA: 0x003E621C File Offset: 0x003E441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE62 RID: 110178 RVA: 0x003E6268 File Offset: 0x003E4468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerStartResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE63 RID: 110179 RVA: 0x003E62B8 File Offset: 0x003E44B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE64 RID: 110180 RVA: 0x003E62C4 File Offset: 0x003E44C4
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
				if (num != 40U)
				{
					if (num != 56U)
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
					this.NeedUpdateSeason = input.ReadBool();
				}
			}
		}

		// Token: 0x04009BFE RID: 39934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BFF RID: 39935
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009C00 RID: 39936
		private ErrorCode errorCode_;

		// Token: 0x04009C01 RID: 39937
		public const int NeedUpdateSeasonFieldNumber = 5;

		// Token: 0x04009C02 RID: 39938
		private bool needUpdateSeason_;
	}
}
