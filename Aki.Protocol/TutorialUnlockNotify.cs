using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001478 RID: 5240
	[NetMessage(EMessageId.TutorialUnlockNotify)]
	public sealed class TutorialUnlockNotify : IMessage<TutorialUnlockNotify>, IMessage, IEquatable<TutorialUnlockNotify>, IDeepCloneable<TutorialUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601BBC7 RID: 113607 RVA: 0x004035EE File Offset: 0x004017EE
		[NullableContext(1)]
		public static TutorialUnlockNotify Create()
		{
			return new TutorialUnlockNotify();
		}

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x0601BBC8 RID: 113608 RVA: 0x004035F5 File Offset: 0x004017F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x0601BBC9 RID: 113609 RVA: 0x004035F8 File Offset: 0x004017F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601BBCA RID: 113610 RVA: 0x004035FF File Offset: 0x004017FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockNotify()
		{
		}

		// Token: 0x0601BBCB RID: 113611 RVA: 0x00403612 File Offset: 0x00401812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockNotify(TutorialUnlockNotify other) : this()
		{
			this.unLockList_ = other.unLockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBCC RID: 113612 RVA: 0x0040363C File Offset: 0x0040183C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockNotify Clone()
		{
			return new TutorialUnlockNotify(this);
		}

		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x0601BBCD RID: 113613 RVA: 0x00403644 File Offset: 0x00401844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TutorialInfo> UnLockList
		{
			get
			{
				return this.unLockList_;
			}
		}

		// Token: 0x0601BBCE RID: 113614 RVA: 0x0040364C File Offset: 0x0040184C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialUnlockNotify);
		}

		// Token: 0x0601BBCF RID: 113615 RVA: 0x0040365A File Offset: 0x0040185A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialUnlockNotify other)
		{
			return other != null && (other == this || (this.unLockList_.Equals(other.unLockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBD0 RID: 113616 RVA: 0x00403690 File Offset: 0x00401890
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

		// Token: 0x0601BBD1 RID: 113617 RVA: 0x004036C4 File Offset: 0x004018C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBD2 RID: 113618 RVA: 0x004036D1 File Offset: 0x004018D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBD3 RID: 113619 RVA: 0x004036DA File Offset: 0x004018DA
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

		// Token: 0x0601BBD4 RID: 113620 RVA: 0x00403704 File Offset: 0x00401904
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

		// Token: 0x0601BBD5 RID: 113621 RVA: 0x0040373D File Offset: 0x0040193D
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

		// Token: 0x0601BBD6 RID: 113622 RVA: 0x0040376B File Offset: 0x0040196B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBD7 RID: 113623 RVA: 0x00403774 File Offset: 0x00401974
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unLockList_.AddEntriesFrom(ref input, TutorialUnlockNotify._repeated_unLockList_codec);
				}
			}
		}

		// Token: 0x04009FB8 RID: 40888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FB9 RID: 40889
		public const int UnLockListFieldNumber = 10;

		// Token: 0x04009FBA RID: 40890
		private static readonly FieldCodec<TutorialInfo> _repeated_unLockList_codec = FieldCodec.ForMessage<TutorialInfo>(82U, TutorialInfo.Parser);

		// Token: 0x04009FBB RID: 40891
		private readonly RepeatedField<TutorialInfo> unLockList_ = new RepeatedField<TutorialInfo>();
	}
}
