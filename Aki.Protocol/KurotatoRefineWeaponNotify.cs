using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089E RID: 2206
	[NetMessage(EMessageId.KurotatoRefineWeaponNotify)]
	public sealed class KurotatoRefineWeaponNotify : IMessage<KurotatoRefineWeaponNotify>, IMessage, IEquatable<KurotatoRefineWeaponNotify>, IDeepCloneable<KurotatoRefineWeaponNotify>, IBufferMessage
	{
		// Token: 0x0600C439 RID: 50233 RVA: 0x001D14B8 File Offset: 0x001CF6B8
		[NullableContext(1)]
		public static KurotatoRefineWeaponNotify Create()
		{
			return new KurotatoRefineWeaponNotify();
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x0600C43A RID: 50234 RVA: 0x001D14BF File Offset: 0x001CF6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x0600C43B RID: 50235 RVA: 0x001D14C2 File Offset: 0x001CF6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRefineWeaponNotify.Descriptor;
			}
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x001D14C9 File Offset: 0x001CF6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponNotify()
		{
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x001D14DC File Offset: 0x001CF6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponNotify(KurotatoRefineWeaponNotify other) : this()
		{
			this.refinedWeaponIncIds_ = other.refinedWeaponIncIds_.Clone();
			this.newWeaponIncId_ = other.newWeaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x001D1512 File Offset: 0x001CF712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponNotify Clone()
		{
			return new KurotatoRefineWeaponNotify(this);
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0600C43F RID: 50239 RVA: 0x001D151A File Offset: 0x001CF71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RefinedWeaponIncIds
		{
			get
			{
				return this.refinedWeaponIncIds_;
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0600C440 RID: 50240 RVA: 0x001D1522 File Offset: 0x001CF722
		// (set) Token: 0x0600C441 RID: 50241 RVA: 0x001D152A File Offset: 0x001CF72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewWeaponIncId
		{
			get
			{
				return this.newWeaponIncId_;
			}
			set
			{
				this.newWeaponIncId_ = value;
			}
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x001D1533 File Offset: 0x001CF733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRefineWeaponNotify);
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x001D1544 File Offset: 0x001CF744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRefineWeaponNotify other)
		{
			return other != null && (other == this || (this.refinedWeaponIncIds_.Equals(other.refinedWeaponIncIds_) && this.NewWeaponIncId == other.NewWeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C444 RID: 50244 RVA: 0x001D1594 File Offset: 0x001CF794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.refinedWeaponIncIds_.GetHashCode();
			if (this.NewWeaponIncId != 0)
			{
				num ^= this.NewWeaponIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C445 RID: 50245 RVA: 0x001D15E1 File Offset: 0x001CF7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x001D15EE File Offset: 0x001CF7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x001D15F8 File Offset: 0x001CF7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewWeaponIncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NewWeaponIncId);
			}
			this.refinedWeaponIncIds_.WriteTo(ref output, KurotatoRefineWeaponNotify._repeated_refinedWeaponIncIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x001D1648 File Offset: 0x001CF848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.refinedWeaponIncIds_.CalculateSize(KurotatoRefineWeaponNotify._repeated_refinedWeaponIncIds_codec);
			if (this.NewWeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewWeaponIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x001D169C File Offset: 0x001CF89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRefineWeaponNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.refinedWeaponIncIds_.Add(other.refinedWeaponIncIds_);
			if (other.NewWeaponIncId != 0)
			{
				this.NewWeaponIncId = other.NewWeaponIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C44A RID: 50250 RVA: 0x001D16E9 File Offset: 0x001CF8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x001D16F4 File Offset: 0x001CF8F4
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
				if (num != 24U)
				{
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.refinedWeaponIncIds_.AddEntriesFrom(ref input, KurotatoRefineWeaponNotify._repeated_refinedWeaponIncIds_codec);
					}
				}
				else
				{
					this.NewWeaponIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054F6 RID: 21750
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F7 RID: 21751
		public const int RefinedWeaponIncIdsFieldNumber = 4;

		// Token: 0x040054F8 RID: 21752
		private static readonly FieldCodec<int> _repeated_refinedWeaponIncIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040054F9 RID: 21753
		private readonly RepeatedField<int> refinedWeaponIncIds_ = new RepeatedField<int>();

		// Token: 0x040054FA RID: 21754
		public const int NewWeaponIncIdFieldNumber = 3;

		// Token: 0x040054FB RID: 21755
		private int newWeaponIncId_;
	}
}
