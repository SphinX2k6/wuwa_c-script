using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C58 RID: 3160
	[NetMessage(EMessageId.PhantomBattleCardRewardInfoUpdateNotify)]
	public sealed class PhantomBattleCardRewardInfoUpdateNotify : IMessage<PhantomBattleCardRewardInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleCardRewardInfoUpdateNotify>, IDeepCloneable<PhantomBattleCardRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011224 RID: 70180 RVA: 0x002823D2 File Offset: 0x002805D2
		[NullableContext(1)]
		public static PhantomBattleCardRewardInfoUpdateNotify Create()
		{
			return new PhantomBattleCardRewardInfoUpdateNotify();
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x06011225 RID: 70181 RVA: 0x002823D9 File Offset: 0x002805D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x06011226 RID: 70182 RVA: 0x002823DC File Offset: 0x002805DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011227 RID: 70183 RVA: 0x002823E3 File Offset: 0x002805E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06011228 RID: 70184 RVA: 0x002823F6 File Offset: 0x002805F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfoUpdateNotify(PhantomBattleCardRewardInfoUpdateNotify other) : this()
		{
			this.phantomBattleCardRewardInfos_ = other.phantomBattleCardRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011229 RID: 70185 RVA: 0x00282420 File Offset: 0x00280620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfoUpdateNotify Clone()
		{
			return new PhantomBattleCardRewardInfoUpdateNotify(this);
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0601122A RID: 70186 RVA: 0x00282428 File Offset: 0x00280628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardRewardInfo> PhantomBattleCardRewardInfos
		{
			get
			{
				return this.phantomBattleCardRewardInfos_;
			}
		}

		// Token: 0x0601122B RID: 70187 RVA: 0x00282430 File Offset: 0x00280630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardInfoUpdateNotify);
		}

		// Token: 0x0601122C RID: 70188 RVA: 0x0028243E File Offset: 0x0028063E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleCardRewardInfos_.Equals(other.phantomBattleCardRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601122D RID: 70189 RVA: 0x00282474 File Offset: 0x00280674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleCardRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601122E RID: 70190 RVA: 0x002824A8 File Offset: 0x002806A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601122F RID: 70191 RVA: 0x002824B5 File Offset: 0x002806B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011230 RID: 70192 RVA: 0x002824BE File Offset: 0x002806BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleCardRewardInfos_.WriteTo(ref output, PhantomBattleCardRewardInfoUpdateNotify._repeated_phantomBattleCardRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011231 RID: 70193 RVA: 0x002824E8 File Offset: 0x002806E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleCardRewardInfos_.CalculateSize(PhantomBattleCardRewardInfoUpdateNotify._repeated_phantomBattleCardRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011232 RID: 70194 RVA: 0x00282521 File Offset: 0x00280721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleCardRewardInfos_.Add(other.phantomBattleCardRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011233 RID: 70195 RVA: 0x0028254F File Offset: 0x0028074F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011234 RID: 70196 RVA: 0x00282558 File Offset: 0x00280758
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
					this.phantomBattleCardRewardInfos_.AddEntriesFrom(ref input, PhantomBattleCardRewardInfoUpdateNotify._repeated_phantomBattleCardRewardInfos_codec);
				}
			}
		}

		// Token: 0x04006C79 RID: 27769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C7A RID: 27770
		public const int PhantomBattleCardRewardInfosFieldNumber = 4;

		// Token: 0x04006C7B RID: 27771
		private static readonly FieldCodec<PhantomBattleCardRewardInfo> _repeated_phantomBattleCardRewardInfos_codec = FieldCodec.ForMessage<PhantomBattleCardRewardInfo>(34U, PhantomBattleCardRewardInfo.Parser);

		// Token: 0x04006C7C RID: 27772
		private readonly RepeatedField<PhantomBattleCardRewardInfo> phantomBattleCardRewardInfos_ = new RepeatedField<PhantomBattleCardRewardInfo>();
	}
}
