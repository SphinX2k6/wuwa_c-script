using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8A RID: 3210
	[NetMessage(EMessageId.PhantomBattleFourCTaskInfoUpdateNotify)]
	public sealed class PhantomBattleFourCTaskInfoUpdateNotify : IMessage<PhantomBattleFourCTaskInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleFourCTaskInfoUpdateNotify>, IDeepCloneable<PhantomBattleFourCTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011668 RID: 71272 RVA: 0x0028CC44 File Offset: 0x0028AE44
		[NullableContext(1)]
		public static PhantomBattleFourCTaskInfoUpdateNotify Create()
		{
			return new PhantomBattleFourCTaskInfoUpdateNotify();
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x06011669 RID: 71273 RVA: 0x0028CC4B File Offset: 0x0028AE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0601166A RID: 71274 RVA: 0x0028CC4E File Offset: 0x0028AE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFourCTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601166B RID: 71275 RVA: 0x0028CC55 File Offset: 0x0028AE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0601166C RID: 71276 RVA: 0x0028CC68 File Offset: 0x0028AE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskInfoUpdateNotify(PhantomBattleFourCTaskInfoUpdateNotify other) : this()
		{
			this.phantomBattleGamerFourCTaskInfo_ = other.phantomBattleGamerFourCTaskInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601166D RID: 71277 RVA: 0x0028CC92 File Offset: 0x0028AE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskInfoUpdateNotify Clone()
		{
			return new PhantomBattleFourCTaskInfoUpdateNotify(this);
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0601166E RID: 71278 RVA: 0x0028CC9A File Offset: 0x0028AE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleGamerFourCTaskInfo> PhantomBattleGamerFourCTaskInfo
		{
			get
			{
				return this.phantomBattleGamerFourCTaskInfo_;
			}
		}

		// Token: 0x0601166F RID: 71279 RVA: 0x0028CCA2 File Offset: 0x0028AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFourCTaskInfoUpdateNotify);
		}

		// Token: 0x06011670 RID: 71280 RVA: 0x0028CCB0 File Offset: 0x0028AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFourCTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleGamerFourCTaskInfo_.Equals(other.phantomBattleGamerFourCTaskInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011671 RID: 71281 RVA: 0x0028CCE4 File Offset: 0x0028AEE4
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

		// Token: 0x06011672 RID: 71282 RVA: 0x0028CD18 File Offset: 0x0028AF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011673 RID: 71283 RVA: 0x0028CD25 File Offset: 0x0028AF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011674 RID: 71284 RVA: 0x0028CD2E File Offset: 0x0028AF2E
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

		// Token: 0x06011675 RID: 71285 RVA: 0x0028CD58 File Offset: 0x0028AF58
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

		// Token: 0x06011676 RID: 71286 RVA: 0x0028CD91 File Offset: 0x0028AF91
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

		// Token: 0x06011677 RID: 71287 RVA: 0x0028CDBF File Offset: 0x0028AFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011678 RID: 71288 RVA: 0x0028CDC8 File Offset: 0x0028AFC8
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
					this.phantomBattleGamerFourCTaskInfo_.AddEntriesFrom(ref input, PhantomBattleFourCTaskInfoUpdateNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
				}
			}
		}

		// Token: 0x04006DE1 RID: 28129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DE2 RID: 28130
		public const int PhantomBattleGamerFourCTaskInfoFieldNumber = 4;

		// Token: 0x04006DE3 RID: 28131
		private static readonly FieldCodec<PhantomBattleGamerFourCTaskInfo> _repeated_phantomBattleGamerFourCTaskInfo_codec = FieldCodec.ForMessage<PhantomBattleGamerFourCTaskInfo>(34U, Aki.Protocol.PhantomBattleGamerFourCTaskInfo.Parser);

		// Token: 0x04006DE4 RID: 28132
		private readonly RepeatedField<PhantomBattleGamerFourCTaskInfo> phantomBattleGamerFourCTaskInfo_ = new RepeatedField<PhantomBattleGamerFourCTaskInfo>();
	}
}
