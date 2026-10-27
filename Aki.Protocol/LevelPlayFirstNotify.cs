using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FA RID: 2298
	[NetMessage(EMessageId.LevelPlayFirstNotify)]
	public sealed class LevelPlayFirstNotify : IMessage<LevelPlayFirstNotify>, IMessage, IEquatable<LevelPlayFirstNotify>, IDeepCloneable<LevelPlayFirstNotify>, IBufferMessage
	{
		// Token: 0x0600CB10 RID: 51984 RVA: 0x001DF651 File Offset: 0x001DD851
		[NullableContext(1)]
		public static LevelPlayFirstNotify Create()
		{
			return new LevelPlayFirstNotify();
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600CB11 RID: 51985 RVA: 0x001DF658 File Offset: 0x001DD858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600CB12 RID: 51986 RVA: 0x001DF65B File Offset: 0x001DD85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayFirstNotify.Descriptor;
			}
		}

		// Token: 0x0600CB13 RID: 51987 RVA: 0x001DF662 File Offset: 0x001DD862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFirstNotify()
		{
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x001DF66A File Offset: 0x001DD86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFirstNotify(LevelPlayFirstNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x001DF68F File Offset: 0x001DD88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFirstNotify Clone()
		{
			return new LevelPlayFirstNotify(this);
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600CB16 RID: 51990 RVA: 0x001DF697 File Offset: 0x001DD897
		// (set) Token: 0x0600CB17 RID: 51991 RVA: 0x001DF69F File Offset: 0x001DD89F
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

		// Token: 0x0600CB18 RID: 51992 RVA: 0x001DF6A8 File Offset: 0x001DD8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayFirstNotify);
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x001DF6B6 File Offset: 0x001DD8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayFirstNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x001DF6E4 File Offset: 0x001DD8E4
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

		// Token: 0x0600CB1B RID: 51995 RVA: 0x001DF723 File Offset: 0x001DD923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB1C RID: 51996 RVA: 0x001DF730 File Offset: 0x001DD930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x001DF739 File Offset: 0x001DD939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x001DF76C File Offset: 0x001DD96C
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

		// Token: 0x0600CB1F RID: 51999 RVA: 0x001DF7AA File Offset: 0x001DD9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayFirstNotify other)
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

		// Token: 0x0600CB20 RID: 52000 RVA: 0x001DF7DB File Offset: 0x001DD9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x001DF7E4 File Offset: 0x001DD9E4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400564E RID: 22094
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400564F RID: 22095
		public const int IdFieldNumber = 1;

		// Token: 0x04005650 RID: 22096
		private int id_;
	}
}
