using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EB RID: 5355
	[NetMessage(EMessageId.TutorialUnlockNotify)]
	public sealed class TutorialUnlockNotify : IMessage<TutorialUnlockNotify>, IMessage, IEquatable<TutorialUnlockNotify>, IDeepCloneable<TutorialUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601C652 RID: 116306 RVA: 0x0041E8B6 File Offset: 0x0041CAB6
		[NullableContext(1)]
		public static TutorialUnlockNotify Create()
		{
			return new TutorialUnlockNotify();
		}

		// Token: 0x1700601B RID: 24603
		// (get) Token: 0x0601C653 RID: 116307 RVA: 0x0041E8BD File Offset: 0x0041CABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700601C RID: 24604
		// (get) Token: 0x0601C654 RID: 116308 RVA: 0x0041E8C0 File Offset: 0x0041CAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601C655 RID: 116309 RVA: 0x0041E8C7 File Offset: 0x0041CAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockNotify()
		{
		}

		// Token: 0x0601C656 RID: 116310 RVA: 0x0041E8DA File Offset: 0x0041CADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockNotify(TutorialUnlockNotify other) : this()
		{
			this.unLockList_ = other.unLockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C657 RID: 116311 RVA: 0x0041E904 File Offset: 0x0041CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockNotify Clone()
		{
			return new TutorialUnlockNotify(this);
		}

		// Token: 0x1700601D RID: 24605
		// (get) Token: 0x0601C658 RID: 116312 RVA: 0x0041E90C File Offset: 0x0041CB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TutorialInfo> UnLockList
		{
			get
			{
				return this.unLockList_;
			}
		}

		// Token: 0x0601C659 RID: 116313 RVA: 0x0041E914 File Offset: 0x0041CB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialUnlockNotify);
		}

		// Token: 0x0601C65A RID: 116314 RVA: 0x0041E922 File Offset: 0x0041CB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialUnlockNotify other)
		{
			return other != null && (other == this || (this.unLockList_.Equals(other.unLockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C65B RID: 116315 RVA: 0x0041E958 File Offset: 0x0041CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unLockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C65C RID: 116316 RVA: 0x0041E98C File Offset: 0x0041CB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C65D RID: 116317 RVA: 0x0041E999 File Offset: 0x0041CB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C65E RID: 116318 RVA: 0x0041E9A2 File Offset: 0x0041CBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unLockList_.WriteTo(ref output, TutorialUnlockNotify._repeated_unLockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C65F RID: 116319 RVA: 0x0041E9CC File Offset: 0x0041CBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unLockList_.CalculateSize(TutorialUnlockNotify._repeated_unLockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C660 RID: 116320 RVA: 0x0041EA05 File Offset: 0x0041CC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unLockList_.Add(other.unLockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C661 RID: 116321 RVA: 0x0041EA33 File Offset: 0x0041CC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C662 RID: 116322 RVA: 0x0041EA3C File Offset: 0x0041CC3C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unLockList_.AddEntriesFrom(ref input, TutorialUnlockNotify._repeated_unLockList_codec);
				}
			}
		}

		// Token: 0x0400A3FF RID: 41983
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A400 RID: 41984
		public const int UnLockListFieldNumber = 12;

		// Token: 0x0400A401 RID: 41985
		private static readonly FieldCodec<TutorialInfo> _repeated_unLockList_codec = FieldCodec.ForMessage<TutorialInfo>(98U, TutorialInfo.Parser);

		// Token: 0x0400A402 RID: 41986
		private readonly RepeatedField<TutorialInfo> unLockList_ = new RepeatedField<TutorialInfo>();
	}
}
