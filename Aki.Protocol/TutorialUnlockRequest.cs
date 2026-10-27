using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001479 RID: 5241
	[NetMessage(EMessageId.TutorialUnlockRequest)]
	public sealed class TutorialUnlockRequest : IMessage<TutorialUnlockRequest>, IMessage, IEquatable<TutorialUnlockRequest>, IDeepCloneable<TutorialUnlockRequest>, IBufferMessage
	{
		// Token: 0x0601BBD9 RID: 113625 RVA: 0x004037D1 File Offset: 0x004019D1
		[NullableContext(1)]
		public static TutorialUnlockRequest Create()
		{
			return new TutorialUnlockRequest();
		}

		// Token: 0x17005D89 RID: 23945
		// (get) Token: 0x0601BBDA RID: 113626 RVA: 0x004037D8 File Offset: 0x004019D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D8A RID: 23946
		// (get) Token: 0x0601BBDB RID: 113627 RVA: 0x004037DB File Offset: 0x004019DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0601BBDC RID: 113628 RVA: 0x004037E2 File Offset: 0x004019E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockRequest()
		{
		}

		// Token: 0x0601BBDD RID: 113629 RVA: 0x004037EA File Offset: 0x004019EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockRequest(TutorialUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBDE RID: 113630 RVA: 0x0040380F File Offset: 0x00401A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockRequest Clone()
		{
			return new TutorialUnlockRequest(this);
		}

		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x0601BBDF RID: 113631 RVA: 0x00403817 File Offset: 0x00401A17
		// (set) Token: 0x0601BBE0 RID: 113632 RVA: 0x0040381F File Offset: 0x00401A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601BBE1 RID: 113633 RVA: 0x00403828 File Offset: 0x00401A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialUnlockRequest);
		}

		// Token: 0x0601BBE2 RID: 113634 RVA: 0x00403836 File Offset: 0x00401A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBE3 RID: 113635 RVA: 0x00403864 File Offset: 0x00401A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BBE4 RID: 113636 RVA: 0x004038A3 File Offset: 0x00401AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBE5 RID: 113637 RVA: 0x004038B0 File Offset: 0x00401AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBE6 RID: 113638 RVA: 0x004038B9 File Offset: 0x00401AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBE7 RID: 113639 RVA: 0x004038EC File Offset: 0x00401AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BBE8 RID: 113640 RVA: 0x0040392A File Offset: 0x00401B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BBE9 RID: 113641 RVA: 0x0040395B File Offset: 0x00401B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBEA RID: 113642 RVA: 0x00403964 File Offset: 0x00401B64
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FBC RID: 40892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FBD RID: 40893
		public const int IdFieldNumber = 6;

		// Token: 0x04009FBE RID: 40894
		private int id_;
	}
}
