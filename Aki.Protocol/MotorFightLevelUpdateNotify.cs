using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A38 RID: 2616
	[NetMessage(EMessageId.MotorFightLevelUpdateNotify)]
	public sealed class MotorFightLevelUpdateNotify : IMessage<MotorFightLevelUpdateNotify>, IMessage, IEquatable<MotorFightLevelUpdateNotify>, IDeepCloneable<MotorFightLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E4B9 RID: 58553 RVA: 0x00217596 File Offset: 0x00215796
		[NullableContext(1)]
		public static MotorFightLevelUpdateNotify Create()
		{
			return new MotorFightLevelUpdateNotify();
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x0021759D File Offset: 0x0021579D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x002175A0 File Offset: 0x002157A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E4BC RID: 58556 RVA: 0x002175A7 File Offset: 0x002157A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelUpdateNotify()
		{
		}

		// Token: 0x0600E4BD RID: 58557 RVA: 0x002175BA File Offset: 0x002157BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelUpdateNotify(MotorFightLevelUpdateNotify other) : this()
		{
			this.motorFightLevelPb_ = other.motorFightLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x002175E4 File Offset: 0x002157E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLevelUpdateNotify Clone()
		{
			return new MotorFightLevelUpdateNotify(this);
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x002175EC File Offset: 0x002157EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightLevelPb> MotorFightLevelPb
		{
			get
			{
				return this.motorFightLevelPb_;
			}
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x002175F4 File Offset: 0x002157F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLevelUpdateNotify);
		}

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x00217602 File Offset: 0x00215802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.motorFightLevelPb_.Equals(other.motorFightLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x00217638 File Offset: 0x00215838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorFightLevelPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4C3 RID: 58563 RVA: 0x0021766C File Offset: 0x0021586C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4C4 RID: 58564 RVA: 0x00217679 File Offset: 0x00215879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4C5 RID: 58565 RVA: 0x00217682 File Offset: 0x00215882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorFightLevelPb_.WriteTo(ref output, MotorFightLevelUpdateNotify._repeated_motorFightLevelPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4C6 RID: 58566 RVA: 0x002176AC File Offset: 0x002158AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorFightLevelPb_.CalculateSize(MotorFightLevelUpdateNotify._repeated_motorFightLevelPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4C7 RID: 58567 RVA: 0x002176E5 File Offset: 0x002158E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.motorFightLevelPb_.Add(other.motorFightLevelPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4C8 RID: 58568 RVA: 0x00217713 File Offset: 0x00215913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4C9 RID: 58569 RVA: 0x0021771C File Offset: 0x0021591C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorFightLevelPb_.AddEntriesFrom(ref input, MotorFightLevelUpdateNotify._repeated_motorFightLevelPb_codec);
				}
			}
		}

		// Token: 0x04005DE4 RID: 24036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DE5 RID: 24037
		public const int MotorFightLevelPbFieldNumber = 3;

		// Token: 0x04005DE6 RID: 24038
		private static readonly FieldCodec<MotorFightLevelPb> _repeated_motorFightLevelPb_codec = FieldCodec.ForMessage<MotorFightLevelPb>(26U, Aki.Protocol.MotorFightLevelPb.Parser);

		// Token: 0x04005DE7 RID: 24039
		private readonly RepeatedField<MotorFightLevelPb> motorFightLevelPb_ = new RepeatedField<MotorFightLevelPb>();
	}
}
