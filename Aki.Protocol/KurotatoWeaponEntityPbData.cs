using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DD RID: 2269
	public sealed class KurotatoWeaponEntityPbData : IMessage<KurotatoWeaponEntityPbData>, IMessage, IEquatable<KurotatoWeaponEntityPbData>, IDeepCloneable<KurotatoWeaponEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C8DC RID: 51420 RVA: 0x001DB07A File Offset: 0x001D927A
		[NullableContext(1)]
		public static KurotatoWeaponEntityPbData Create()
		{
			return new KurotatoWeaponEntityPbData();
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600C8DD RID: 51421 RVA: 0x001DB081 File Offset: 0x001D9281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0600C8DE RID: 51422 RVA: 0x001DB084 File Offset: 0x001D9284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C8DF RID: 51423 RVA: 0x001DB08B File Offset: 0x001D928B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData()
		{
		}

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x001DB093 File Offset: 0x001D9293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData(KurotatoWeaponEntityPbData other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x001DB0B8 File Offset: 0x001D92B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData Clone()
		{
			return new KurotatoWeaponEntityPbData(this);
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0600C8E2 RID: 51426 RVA: 0x001DB0C0 File Offset: 0x001D92C0
		// (set) Token: 0x0600C8E3 RID: 51427 RVA: 0x001DB0C8 File Offset: 0x001D92C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x001DB0D1 File Offset: 0x001D92D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponEntityPbData);
		}

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x001DB0DF File Offset: 0x001D92DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponEntityPbData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x001DB110 File Offset: 0x001D9310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x001DB14F File Offset: 0x001D934F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x001DB15C File Offset: 0x001D935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x001DB165 File Offset: 0x001D9365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x001DB198 File Offset: 0x001D9398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x001DB1D6 File Offset: 0x001D93D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoWeaponEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x001DB207 File Offset: 0x001D9407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x001DB210 File Offset: 0x001D9410
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055CC RID: 21964
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055CD RID: 21965
		public const int IncIdFieldNumber = 1;

		// Token: 0x040055CE RID: 21966
		private int incId_;
	}
}
