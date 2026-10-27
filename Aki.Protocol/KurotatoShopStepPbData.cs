using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CD RID: 2253
	public sealed class KurotatoShopStepPbData : IMessage<KurotatoShopStepPbData>, IMessage, IEquatable<KurotatoShopStepPbData>, IDeepCloneable<KurotatoShopStepPbData>, IBufferMessage
	{
		// Token: 0x0600C7A6 RID: 51110 RVA: 0x001D8623 File Offset: 0x001D6823
		[NullableContext(1)]
		public static KurotatoShopStepPbData Create()
		{
			return new KurotatoShopStepPbData();
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600C7A7 RID: 51111 RVA: 0x001D862A File Offset: 0x001D682A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600C7A8 RID: 51112 RVA: 0x001D862D File Offset: 0x001D682D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C7A9 RID: 51113 RVA: 0x001D8634 File Offset: 0x001D6834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData()
		{
		}

		// Token: 0x0600C7AA RID: 51114 RVA: 0x001D863C File Offset: 0x001D683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData(KurotatoShopStepPbData other) : this()
		{
			this.hasEndLessModeSelection_ = other.hasEndLessModeSelection_;
			this.nextWaveType_ = other.nextWaveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7AB RID: 51115 RVA: 0x001D866D File Offset: 0x001D686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopStepPbData Clone()
		{
			return new KurotatoShopStepPbData(this);
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x001D8675 File Offset: 0x001D6875
		// (set) Token: 0x0600C7AD RID: 51117 RVA: 0x001D867D File Offset: 0x001D687D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEndLessModeSelection
		{
			get
			{
				return this.hasEndLessModeSelection_;
			}
			set
			{
				this.hasEndLessModeSelection_ = value;
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x001D8686 File Offset: 0x001D6886
		// (set) Token: 0x0600C7AF RID: 51119 RVA: 0x001D868E File Offset: 0x001D688E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveType NextWaveType
		{
			get
			{
				return this.nextWaveType_;
			}
			set
			{
				this.nextWaveType_ = value;
			}
		}

		// Token: 0x0600C7B0 RID: 51120 RVA: 0x001D8697 File Offset: 0x001D6897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopStepPbData);
		}

		// Token: 0x0600C7B1 RID: 51121 RVA: 0x001D86A5 File Offset: 0x001D68A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopStepPbData other)
		{
			return other != null && (other == this || (this.HasEndLessModeSelection == other.HasEndLessModeSelection && this.NextWaveType == other.NextWaveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7B2 RID: 51122 RVA: 0x001D86E4 File Offset: 0x001D68E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasEndLessModeSelection)
			{
				num ^= this.HasEndLessModeSelection.GetHashCode();
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num ^= this.NextWaveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7B3 RID: 51123 RVA: 0x001D8742 File Offset: 0x001D6942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7B4 RID: 51124 RVA: 0x001D874F File Offset: 0x001D694F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x001D8758 File Offset: 0x001D6958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasEndLessModeSelection)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.HasEndLessModeSelection);
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.NextWaveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x001D87B0 File Offset: 0x001D69B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasEndLessModeSelection)
			{
				num += 2;
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NextWaveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x001D87FC File Offset: 0x001D69FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasEndLessModeSelection)
			{
				this.HasEndLessModeSelection = other.HasEndLessModeSelection;
			}
			if (other.NextWaveType != KurotatoNextWaveType.Default)
			{
				this.NextWaveType = other.NextWaveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x001D884C File Offset: 0x001D6A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7B9 RID: 51129 RVA: 0x001D8858 File Offset: 0x001D6A58
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
						this.NextWaveType = (KurotatoNextWaveType)input.ReadEnum();
					}
				}
				else
				{
					this.HasEndLessModeSelection = input.ReadBool();
				}
			}
		}

		// Token: 0x04005588 RID: 21896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005589 RID: 21897
		public const int HasEndLessModeSelectionFieldNumber = 1;

		// Token: 0x0400558A RID: 21898
		private bool hasEndLessModeSelection_;

		// Token: 0x0400558B RID: 21899
		public const int NextWaveTypeFieldNumber = 2;

		// Token: 0x0400558C RID: 21900
		private KurotatoNextWaveType nextWaveType_;
	}
}
