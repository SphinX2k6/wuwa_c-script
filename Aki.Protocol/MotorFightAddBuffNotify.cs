using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A25 RID: 2597
	[NetMessage(EMessageId.MotorFightAddBuffNotify)]
	public sealed class MotorFightAddBuffNotify : IMessage<MotorFightAddBuffNotify>, IMessage, IEquatable<MotorFightAddBuffNotify>, IDeepCloneable<MotorFightAddBuffNotify>, IBufferMessage
	{
		// Token: 0x0600E331 RID: 58161 RVA: 0x002142DE File Offset: 0x002124DE
		[NullableContext(1)]
		public static MotorFightAddBuffNotify Create()
		{
			return new MotorFightAddBuffNotify();
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600E332 RID: 58162 RVA: 0x002142E5 File Offset: 0x002124E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600E333 RID: 58163 RVA: 0x002142E8 File Offset: 0x002124E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightAddBuffNotify.Descriptor;
			}
		}

		// Token: 0x0600E334 RID: 58164 RVA: 0x002142EF File Offset: 0x002124EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddBuffNotify()
		{
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x00214302 File Offset: 0x00212502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddBuffNotify(MotorFightAddBuffNotify other) : this()
		{
			this.buffs_ = other.buffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E336 RID: 58166 RVA: 0x0021432C File Offset: 0x0021252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightAddBuffNotify Clone()
		{
			return new MotorFightAddBuffNotify(this);
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600E337 RID: 58167 RVA: 0x00214334 File Offset: 0x00212534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightRoundBuffPb> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x0600E338 RID: 58168 RVA: 0x0021433C File Offset: 0x0021253C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightAddBuffNotify);
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x0021434A File Offset: 0x0021254A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightAddBuffNotify other)
		{
			return other != null && (other == this || (this.buffs_.Equals(other.buffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E33A RID: 58170 RVA: 0x00214380 File Offset: 0x00212580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E33B RID: 58171 RVA: 0x002143B4 File Offset: 0x002125B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E33C RID: 58172 RVA: 0x002143C1 File Offset: 0x002125C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E33D RID: 58173 RVA: 0x002143CA File Offset: 0x002125CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffs_.WriteTo(ref output, MotorFightAddBuffNotify._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E33E RID: 58174 RVA: 0x002143F4 File Offset: 0x002125F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffs_.CalculateSize(MotorFightAddBuffNotify._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E33F RID: 58175 RVA: 0x0021442D File Offset: 0x0021262D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightAddBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.buffs_.Add(other.buffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E340 RID: 58176 RVA: 0x0021445B File Offset: 0x0021265B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x00214464 File Offset: 0x00212664
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffs_.AddEntriesFrom(ref input, MotorFightAddBuffNotify._repeated_buffs_codec);
				}
			}
		}

		// Token: 0x04005D79 RID: 23929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D7A RID: 23930
		public const int BuffsFieldNumber = 4;

		// Token: 0x04005D7B RID: 23931
		private static readonly FieldCodec<MotorFightRoundBuffPb> _repeated_buffs_codec = FieldCodec.ForMessage<MotorFightRoundBuffPb>(34U, MotorFightRoundBuffPb.Parser);

		// Token: 0x04005D7C RID: 23932
		private readonly RepeatedField<MotorFightRoundBuffPb> buffs_ = new RepeatedField<MotorFightRoundBuffPb>();
	}
}
