using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E8 RID: 5352
	[NetMessage(EMessageId.TutorialInfoResponse)]
	public sealed class TutorialInfoResponse : IMessage<TutorialInfoResponse>, IMessage, IEquatable<TutorialInfoResponse>, IDeepCloneable<TutorialInfoResponse>, IBufferMessage
	{
		// Token: 0x0601C619 RID: 116249 RVA: 0x0041E19A File Offset: 0x0041C39A
		[NullableContext(1)]
		public static TutorialInfoResponse Create()
		{
			return new TutorialInfoResponse();
		}

		// Token: 0x17006010 RID: 24592
		// (get) Token: 0x0601C61A RID: 116250 RVA: 0x0041E1A1 File Offset: 0x0041C3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006011 RID: 24593
		// (get) Token: 0x0601C61B RID: 116251 RVA: 0x0041E1A4 File Offset: 0x0041C3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601C61C RID: 116252 RVA: 0x0041E1AB File Offset: 0x0041C3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoResponse()
		{
		}

		// Token: 0x0601C61D RID: 116253 RVA: 0x0041E1BE File Offset: 0x0041C3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoResponse(TutorialInfoResponse other) : this()
		{
			this.unLockList_ = other.unLockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C61E RID: 116254 RVA: 0x0041E1E8 File Offset: 0x0041C3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfoResponse Clone()
		{
			return new TutorialInfoResponse(this);
		}

		// Token: 0x17006012 RID: 24594
		// (get) Token: 0x0601C61F RID: 116255 RVA: 0x0041E1F0 File Offset: 0x0041C3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TutorialInfo> UnLockList
		{
			get
			{
				return this.unLockList_;
			}
		}

		// Token: 0x0601C620 RID: 116256 RVA: 0x0041E1F8 File Offset: 0x0041C3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialInfoResponse);
		}

		// Token: 0x0601C621 RID: 116257 RVA: 0x0041E206 File Offset: 0x0041C406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialInfoResponse other)
		{
			return other != null && (other == this || (this.unLockList_.Equals(other.unLockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C622 RID: 116258 RVA: 0x0041E23C File Offset: 0x0041C43C
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

		// Token: 0x0601C623 RID: 116259 RVA: 0x0041E270 File Offset: 0x0041C470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C624 RID: 116260 RVA: 0x0041E27D File Offset: 0x0041C47D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C625 RID: 116261 RVA: 0x0041E286 File Offset: 0x0041C486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unLockList_.WriteTo(ref output, TutorialInfoResponse._repeated_unLockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C626 RID: 116262 RVA: 0x0041E2B0 File Offset: 0x0041C4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unLockList_.CalculateSize(TutorialInfoResponse._repeated_unLockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C627 RID: 116263 RVA: 0x0041E2E9 File Offset: 0x0041C4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.unLockList_.Add(other.unLockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C628 RID: 116264 RVA: 0x0041E317 File Offset: 0x0041C517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C629 RID: 116265 RVA: 0x0041E320 File Offset: 0x0041C520
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unLockList_.AddEntriesFrom(ref input, TutorialInfoResponse._repeated_unLockList_codec);
				}
			}
		}

		// Token: 0x0400A3EF RID: 41967
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3F0 RID: 41968
		public const int UnLockListFieldNumber = 2;

		// Token: 0x0400A3F1 RID: 41969
		private static readonly FieldCodec<TutorialInfo> _repeated_unLockList_codec = FieldCodec.ForMessage<TutorialInfo>(18U, TutorialInfo.Parser);

		// Token: 0x0400A3F2 RID: 41970
		private readonly RepeatedField<TutorialInfo> unLockList_ = new RepeatedField<TutorialInfo>();
	}
}
