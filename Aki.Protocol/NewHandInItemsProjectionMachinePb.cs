using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B16 RID: 2838
	public sealed class NewHandInItemsProjectionMachinePb : IMessage<NewHandInItemsProjectionMachinePb>, IMessage, IEquatable<NewHandInItemsProjectionMachinePb>, IDeepCloneable<NewHandInItemsProjectionMachinePb>, IBufferMessage
	{
		// Token: 0x0600F672 RID: 63090 RVA: 0x0023F099 File Offset: 0x0023D299
		[NullableContext(1)]
		public static NewHandInItemsProjectionMachinePb Create()
		{
			return new NewHandInItemsProjectionMachinePb();
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600F673 RID: 63091 RVA: 0x0023F0A0 File Offset: 0x0023D2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600F674 RID: 63092 RVA: 0x0023F0A3 File Offset: 0x0023D2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewHandInItemsProjectionMachinePb.Descriptor;
			}
		}

		// Token: 0x0600F675 RID: 63093 RVA: 0x0023F0AA File Offset: 0x0023D2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb()
		{
		}

		// Token: 0x0600F676 RID: 63094 RVA: 0x0023F0B2 File Offset: 0x0023D2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb(NewHandInItemsProjectionMachinePb other) : this()
		{
			this.entityCfgId_ = other.entityCfgId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F677 RID: 63095 RVA: 0x0023F0E3 File Offset: 0x0023D2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb Clone()
		{
			return new NewHandInItemsProjectionMachinePb(this);
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600F678 RID: 63096 RVA: 0x0023F0EB File Offset: 0x0023D2EB
		// (set) Token: 0x0600F679 RID: 63097 RVA: 0x0023F0F3 File Offset: 0x0023D2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityCfgId
		{
			get
			{
				return this.entityCfgId_;
			}
			set
			{
				this.entityCfgId_ = value;
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600F67A RID: 63098 RVA: 0x0023F0FC File Offset: 0x0023D2FC
		// (set) Token: 0x0600F67B RID: 63099 RVA: 0x0023F104 File Offset: 0x0023D304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x0600F67C RID: 63100 RVA: 0x0023F10D File Offset: 0x0023D30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewHandInItemsProjectionMachinePb);
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x0023F11B File Offset: 0x0023D31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewHandInItemsProjectionMachinePb other)
		{
			return other != null && (other == this || (this.EntityCfgId == other.EntityCfgId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F67E RID: 63102 RVA: 0x0023F15C File Offset: 0x0023D35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityCfgId != 0)
			{
				num ^= this.EntityCfgId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x0023F1B4 File Offset: 0x0023D3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x0023F1C1 File Offset: 0x0023D3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F681 RID: 63105 RVA: 0x0023F1CC File Offset: 0x0023D3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityCfgId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityCfgId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F682 RID: 63106 RVA: 0x0023F224 File Offset: 0x0023D424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityCfgId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F683 RID: 63107 RVA: 0x0023F27C File Offset: 0x0023D47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewHandInItemsProjectionMachinePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityCfgId != 0)
			{
				this.EntityCfgId = other.EntityCfgId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F684 RID: 63108 RVA: 0x0023F2CC File Offset: 0x0023D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F685 RID: 63109 RVA: 0x0023F2D8 File Offset: 0x0023D4D8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityCfgId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062F7 RID: 25335
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062F8 RID: 25336
		public const int EntityCfgIdFieldNumber = 1;

		// Token: 0x040062F9 RID: 25337
		private int entityCfgId_;

		// Token: 0x040062FA RID: 25338
		public const int ItemIdFieldNumber = 2;

		// Token: 0x040062FB RID: 25339
		private int itemId_;
	}
}
