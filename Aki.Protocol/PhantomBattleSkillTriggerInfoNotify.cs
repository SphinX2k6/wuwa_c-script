using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA8 RID: 3240
	[NetMessage(EMessageId.PhantomBattleSkillTriggerInfoNotify)]
	public sealed class PhantomBattleSkillTriggerInfoNotify : IMessage<PhantomBattleSkillTriggerInfoNotify>, IMessage, IEquatable<PhantomBattleSkillTriggerInfoNotify>, IDeepCloneable<PhantomBattleSkillTriggerInfoNotify>, IBufferMessage
	{
		// Token: 0x06011933 RID: 71987 RVA: 0x002936AF File Offset: 0x002918AF
		[NullableContext(1)]
		public static PhantomBattleSkillTriggerInfoNotify Create()
		{
			return new PhantomBattleSkillTriggerInfoNotify();
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x06011934 RID: 71988 RVA: 0x002936B6 File Offset: 0x002918B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x06011935 RID: 71989 RVA: 0x002936B9 File Offset: 0x002918B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSkillTriggerInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011936 RID: 71990 RVA: 0x002936C0 File Offset: 0x002918C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfoNotify()
		{
		}

		// Token: 0x06011937 RID: 71991 RVA: 0x002936D3 File Offset: 0x002918D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfoNotify(PhantomBattleSkillTriggerInfoNotify other) : this()
		{
			this.phantomBattleSkillTriggerInfos_ = other.phantomBattleSkillTriggerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011938 RID: 71992 RVA: 0x002936FD File Offset: 0x002918FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfoNotify Clone()
		{
			return new PhantomBattleSkillTriggerInfoNotify(this);
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x06011939 RID: 71993 RVA: 0x00293705 File Offset: 0x00291905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleSkillTriggerInfo> PhantomBattleSkillTriggerInfos
		{
			get
			{
				return this.phantomBattleSkillTriggerInfos_;
			}
		}

		// Token: 0x0601193A RID: 71994 RVA: 0x0029370D File Offset: 0x0029190D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSkillTriggerInfoNotify);
		}

		// Token: 0x0601193B RID: 71995 RVA: 0x0029371B File Offset: 0x0029191B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSkillTriggerInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleSkillTriggerInfos_.Equals(other.phantomBattleSkillTriggerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601193C RID: 71996 RVA: 0x00293750 File Offset: 0x00291950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleSkillTriggerInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601193D RID: 71997 RVA: 0x00293784 File Offset: 0x00291984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601193E RID: 71998 RVA: 0x00293791 File Offset: 0x00291991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601193F RID: 71999 RVA: 0x0029379A File Offset: 0x0029199A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleSkillTriggerInfos_.WriteTo(ref output, PhantomBattleSkillTriggerInfoNotify._repeated_phantomBattleSkillTriggerInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011940 RID: 72000 RVA: 0x002937C4 File Offset: 0x002919C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleSkillTriggerInfos_.CalculateSize(PhantomBattleSkillTriggerInfoNotify._repeated_phantomBattleSkillTriggerInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011941 RID: 72001 RVA: 0x002937FD File Offset: 0x002919FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSkillTriggerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleSkillTriggerInfos_.Add(other.phantomBattleSkillTriggerInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011942 RID: 72002 RVA: 0x0029382B File Offset: 0x00291A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011943 RID: 72003 RVA: 0x00293834 File Offset: 0x00291A34
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleSkillTriggerInfos_.AddEntriesFrom(ref input, PhantomBattleSkillTriggerInfoNotify._repeated_phantomBattleSkillTriggerInfos_codec);
				}
			}
		}

		// Token: 0x04006F26 RID: 28454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F27 RID: 28455
		public const int PhantomBattleSkillTriggerInfosFieldNumber = 11;

		// Token: 0x04006F28 RID: 28456
		private static readonly FieldCodec<PhantomBattleSkillTriggerInfo> _repeated_phantomBattleSkillTriggerInfos_codec = FieldCodec.ForMessage<PhantomBattleSkillTriggerInfo>(90U, PhantomBattleSkillTriggerInfo.Parser);

		// Token: 0x04006F29 RID: 28457
		private readonly RepeatedField<PhantomBattleSkillTriggerInfo> phantomBattleSkillTriggerInfos_ = new RepeatedField<PhantomBattleSkillTriggerInfo>();
	}
}
