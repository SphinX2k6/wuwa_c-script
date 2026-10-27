using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB3 RID: 3251
	[NetMessage(EMessageId.PhantomBattleSelectTargetRequest)]
	public sealed class PhantomBattleSelectTargetRequest : IMessage<PhantomBattleSelectTargetRequest>, IMessage, IEquatable<PhantomBattleSelectTargetRequest>, IDeepCloneable<PhantomBattleSelectTargetRequest>, IBufferMessage
	{
		// Token: 0x060119C4 RID: 72132 RVA: 0x00294349 File Offset: 0x00292549
		[NullableContext(1)]
		public static PhantomBattleSelectTargetRequest Create()
		{
			return new PhantomBattleSelectTargetRequest();
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x060119C5 RID: 72133 RVA: 0x00294350 File Offset: 0x00292550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x060119C6 RID: 72134 RVA: 0x00294353 File Offset: 0x00292553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectTargetRequest.Descriptor;
			}
		}

		// Token: 0x060119C7 RID: 72135 RVA: 0x0029435A File Offset: 0x0029255A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetRequest()
		{
		}

		// Token: 0x060119C8 RID: 72136 RVA: 0x0029436D File Offset: 0x0029256D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetRequest(PhantomBattleSelectTargetRequest other) : this()
		{
			this.fighterUId_ = other.fighterUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119C9 RID: 72137 RVA: 0x00294397 File Offset: 0x00292597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectTargetRequest Clone()
		{
			return new PhantomBattleSelectTargetRequest(this);
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x060119CA RID: 72138 RVA: 0x0029439F File Offset: 0x0029259F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x060119CB RID: 72139 RVA: 0x002943A7 File Offset: 0x002925A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectTargetRequest);
		}

		// Token: 0x060119CC RID: 72140 RVA: 0x002943B5 File Offset: 0x002925B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectTargetRequest other)
		{
			return other != null && (other == this || (this.fighterUId_.Equals(other.fighterUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119CD RID: 72141 RVA: 0x002943E8 File Offset: 0x002925E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fighterUId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060119CE RID: 72142 RVA: 0x0029441C File Offset: 0x0029261C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119CF RID: 72143 RVA: 0x00294429 File Offset: 0x00292629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119D0 RID: 72144 RVA: 0x00294432 File Offset: 0x00292632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighterUId_.WriteTo(ref output, PhantomBattleSelectTargetRequest._repeated_fighterUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060119D1 RID: 72145 RVA: 0x0029445C File Offset: 0x0029265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fighterUId_.CalculateSize(PhantomBattleSelectTargetRequest._repeated_fighterUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060119D2 RID: 72146 RVA: 0x00294495 File Offset: 0x00292695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.fighterUId_.Add(other.fighterUId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060119D3 RID: 72147 RVA: 0x002944C3 File Offset: 0x002926C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119D4 RID: 72148 RVA: 0x002944CC File Offset: 0x002926CC
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleSelectTargetRequest._repeated_fighterUId_codec);
				}
			}
		}

		// Token: 0x04006EEB RID: 28395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EEC RID: 28396
		public const int FighterUIdFieldNumber = 14;

		// Token: 0x04006EED RID: 28397
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04006EEE RID: 28398
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();
	}
}
