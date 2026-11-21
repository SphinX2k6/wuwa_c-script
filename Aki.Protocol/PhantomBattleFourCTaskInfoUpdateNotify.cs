using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7A RID: 3194
	[NetMessage(EMessageId.PhantomBattleFourCTaskInfoUpdateNotify)]
	public sealed class PhantomBattleFourCTaskInfoUpdateNotify : IMessage<PhantomBattleFourCTaskInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleFourCTaskInfoUpdateNotify>, IDeepCloneable<PhantomBattleFourCTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011568 RID: 71016 RVA: 0x0028AED8 File Offset: 0x002890D8
		[NullableContext(1)]
		public static PhantomBattleFourCTaskInfoUpdateNotify Create()
		{
			return new PhantomBattleFourCTaskInfoUpdateNotify();
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x06011569 RID: 71017 RVA: 0x0028AEDF File Offset: 0x002890DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0601156A RID: 71018 RVA: 0x0028AEE2 File Offset: 0x002890E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFourCTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601156B RID: 71019 RVA: 0x0028AEE9 File Offset: 0x002890E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0601156C RID: 71020 RVA: 0x0028AEFC File Offset: 0x002890FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskInfoUpdateNotify(PhantomBattleFourCTaskInfoUpdateNotify other) : this()
		{
			this.phantomBattleGamerFourCTaskInfo_ = other.phantomBattleGamerFourCTaskInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601156D RID: 71021 RVA: 0x0028AF26 File Offset: 0x00289126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskInfoUpdateNotify Clone()
		{
			return new PhantomBattleFourCTaskInfoUpdateNotify(this);
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0601156E RID: 71022 RVA: 0x0028AF2E File Offset: 0x0028912E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleGamerFourCTaskInfo> PhantomBattleGamerFourCTaskInfo
		{
			get
			{
				return this.phantomBattleGamerFourCTaskInfo_;
			}
		}

		// Token: 0x0601156F RID: 71023 RVA: 0x0028AF36 File Offset: 0x00289136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFourCTaskInfoUpdateNotify);
		}

		// Token: 0x06011570 RID: 71024 RVA: 0x0028AF44 File Offset: 0x00289144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFourCTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleGamerFourCTaskInfo_.Equals(other.phantomBattleGamerFourCTaskInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011571 RID: 71025 RVA: 0x0028AF78 File Offset: 0x00289178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleGamerFourCTaskInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011572 RID: 71026 RVA: 0x0028AFAC File Offset: 0x002891AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011573 RID: 71027 RVA: 0x0028AFB9 File Offset: 0x002891B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011574 RID: 71028 RVA: 0x0028AFC2 File Offset: 0x002891C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleGamerFourCTaskInfo_.WriteTo(ref output, PhantomBattleFourCTaskInfoUpdateNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011575 RID: 71029 RVA: 0x0028AFEC File Offset: 0x002891EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleGamerFourCTaskInfo_.CalculateSize(PhantomBattleFourCTaskInfoUpdateNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011576 RID: 71030 RVA: 0x0028B025 File Offset: 0x00289225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFourCTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleGamerFourCTaskInfo_.Add(other.phantomBattleGamerFourCTaskInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011577 RID: 71031 RVA: 0x0028B053 File Offset: 0x00289253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011578 RID: 71032 RVA: 0x0028B05C File Offset: 0x0028925C
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
					this.phantomBattleGamerFourCTaskInfo_.AddEntriesFrom(ref input, PhantomBattleFourCTaskInfoUpdateNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
				}
			}
		}

		// Token: 0x04006DF5 RID: 28149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DF6 RID: 28150
		public const int PhantomBattleGamerFourCTaskInfoFieldNumber = 11;

		// Token: 0x04006DF7 RID: 28151
		private static readonly FieldCodec<PhantomBattleGamerFourCTaskInfo> _repeated_phantomBattleGamerFourCTaskInfo_codec = FieldCodec.ForMessage<PhantomBattleGamerFourCTaskInfo>(90U, Aki.Protocol.PhantomBattleGamerFourCTaskInfo.Parser);

		// Token: 0x04006DF8 RID: 28152
		private readonly RepeatedField<PhantomBattleGamerFourCTaskInfo> phantomBattleGamerFourCTaskInfo_ = new RepeatedField<PhantomBattleGamerFourCTaskInfo>();
	}
}
