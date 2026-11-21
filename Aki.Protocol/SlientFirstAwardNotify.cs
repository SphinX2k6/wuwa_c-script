using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001294 RID: 4756
	[NetMessage(EMessageId.SlientFirstAwardNotify)]
	public sealed class SlientFirstAwardNotify : IMessage<SlientFirstAwardNotify>, IMessage, IEquatable<SlientFirstAwardNotify>, IDeepCloneable<SlientFirstAwardNotify>, IBufferMessage
	{
		// Token: 0x0601962D RID: 103981 RVA: 0x003B3D88 File Offset: 0x003B1F88
		[NullableContext(1)]
		public static SlientFirstAwardNotify Create()
		{
			return new SlientFirstAwardNotify();
		}

		// Token: 0x170055DF RID: 21983
		// (get) Token: 0x0601962E RID: 103982 RVA: 0x003B3D8F File Offset: 0x003B1F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055E0 RID: 21984
		// (get) Token: 0x0601962F RID: 103983 RVA: 0x003B3D92 File Offset: 0x003B1F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlientFirstAwardNotify.Descriptor;
			}
		}

		// Token: 0x06019630 RID: 103984 RVA: 0x003B3D99 File Offset: 0x003B1F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlientFirstAwardNotify()
		{
		}

		// Token: 0x06019631 RID: 103985 RVA: 0x003B3DA1 File Offset: 0x003B1FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlientFirstAwardNotify(SlientFirstAwardNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019632 RID: 103986 RVA: 0x003B3DC6 File Offset: 0x003B1FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlientFirstAwardNotify Clone()
		{
			return new SlientFirstAwardNotify(this);
		}

		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x06019633 RID: 103987 RVA: 0x003B3DCE File Offset: 0x003B1FCE
		// (set) Token: 0x06019634 RID: 103988 RVA: 0x003B3DD6 File Offset: 0x003B1FD6
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

		// Token: 0x06019635 RID: 103989 RVA: 0x003B3DDF File Offset: 0x003B1FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlientFirstAwardNotify);
		}

		// Token: 0x06019636 RID: 103990 RVA: 0x003B3DED File Offset: 0x003B1FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlientFirstAwardNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019637 RID: 103991 RVA: 0x003B3E1C File Offset: 0x003B201C
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

		// Token: 0x06019638 RID: 103992 RVA: 0x003B3E5B File Offset: 0x003B205B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019639 RID: 103993 RVA: 0x003B3E68 File Offset: 0x003B2068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601963A RID: 103994 RVA: 0x003B3E71 File Offset: 0x003B2071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601963B RID: 103995 RVA: 0x003B3EA4 File Offset: 0x003B20A4
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

		// Token: 0x0601963C RID: 103996 RVA: 0x003B3EE2 File Offset: 0x003B20E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlientFirstAwardNotify other)
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

		// Token: 0x0601963D RID: 103997 RVA: 0x003B3F13 File Offset: 0x003B2113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601963E RID: 103998 RVA: 0x003B3F1C File Offset: 0x003B211C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009621 RID: 38433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009622 RID: 38434
		public const int IdFieldNumber = 4;

		// Token: 0x04009623 RID: 38435
		private int id_;
	}
}
