using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A2 RID: 1698
	[NetMessage(EMessageId.GachaUsePoolRequest)]
	public sealed class GachaUsePoolRequest : IMessage<GachaUsePoolRequest>, IMessage, IEquatable<GachaUsePoolRequest>, IDeepCloneable<GachaUsePoolRequest>, IBufferMessage
	{
		// Token: 0x06009B64 RID: 39780 RVA: 0x00176D5C File Offset: 0x00174F5C
		[NullableContext(1)]
		public static GachaUsePoolRequest Create()
		{
			return new GachaUsePoolRequest();
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x00176D63 File Offset: 0x00174F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06009B66 RID: 39782 RVA: 0x00176D66 File Offset: 0x00174F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaUsePoolRequest.Descriptor;
			}
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x00176D6D File Offset: 0x00174F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolRequest()
		{
		}

		// Token: 0x06009B68 RID: 39784 RVA: 0x00176D75 File Offset: 0x00174F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolRequest(GachaUsePoolRequest other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B69 RID: 39785 RVA: 0x00176DA6 File Offset: 0x00174FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaUsePoolRequest Clone()
		{
			return new GachaUsePoolRequest(this);
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06009B6A RID: 39786 RVA: 0x00176DAE File Offset: 0x00174FAE
		// (set) Token: 0x06009B6B RID: 39787 RVA: 0x00176DB6 File Offset: 0x00174FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06009B6C RID: 39788 RVA: 0x00176DBF File Offset: 0x00174FBF
		// (set) Token: 0x06009B6D RID: 39789 RVA: 0x00176DC7 File Offset: 0x00174FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x00176DD0 File Offset: 0x00174FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaUsePoolRequest);
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x00176DDE File Offset: 0x00174FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaUsePoolRequest other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x00176E1C File Offset: 0x0017501C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.PoolId != 0)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x00176E74 File Offset: 0x00175074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x00176E81 File Offset: 0x00175081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x00176E8C File Offset: 0x0017508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GachaId);
			}
			if (this.PoolId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x00176EE4 File Offset: 0x001750E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			if (this.PoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x00176F3C File Offset: 0x0017513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaUsePoolRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			if (other.PoolId != 0)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B76 RID: 39798 RVA: 0x00176F8C File Offset: 0x0017518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x00176F98 File Offset: 0x00175198
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
				if (num != 8U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PoolId = input.ReadInt32();
					}
				}
				else
				{
					this.GachaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004960 RID: 18784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004961 RID: 18785
		public const int GachaIdFieldNumber = 1;

		// Token: 0x04004962 RID: 18786
		private int gachaId_;

		// Token: 0x04004963 RID: 18787
		public const int PoolIdFieldNumber = 9;

		// Token: 0x04004964 RID: 18788
		private int poolId_;
	}
}
