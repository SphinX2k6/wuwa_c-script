using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000989 RID: 2441
	[NetMessage(EMessageId.MapTraceNotify)]
	public sealed class MapTraceNotify : IMessage<MapTraceNotify>, IMessage, IEquatable<MapTraceNotify>, IDeepCloneable<MapTraceNotify>, IBufferMessage
	{
		// Token: 0x0600D6D4 RID: 54996 RVA: 0x001F9B70 File Offset: 0x001F7D70
		[NullableContext(1)]
		public static MapTraceNotify Create()
		{
			return new MapTraceNotify();
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600D6D5 RID: 54997 RVA: 0x001F9B77 File Offset: 0x001F7D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600D6D6 RID: 54998 RVA: 0x001F9B7A File Offset: 0x001F7D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTraceNotify.Descriptor;
			}
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x001F9B81 File Offset: 0x001F7D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceNotify()
		{
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x001F9B89 File Offset: 0x001F7D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceNotify(MapTraceNotify other) : this()
		{
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x001F9BAE File Offset: 0x001F7DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTraceNotify Clone()
		{
			return new MapTraceNotify(this);
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x001F9BB6 File Offset: 0x001F7DB6
		// (set) Token: 0x0600D6DB RID: 55003 RVA: 0x001F9BBE File Offset: 0x001F7DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x001F9BC7 File Offset: 0x001F7DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTraceNotify);
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x001F9BD5 File Offset: 0x001F7DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTraceNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6DE RID: 55006 RVA: 0x001F9C04 File Offset: 0x001F7E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x001F9C43 File Offset: 0x001F7E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x001F9C50 File Offset: 0x001F7E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x001F9C59 File Offset: 0x001F7E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x001F9C8C File Offset: 0x001F7E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x001F9CCA File Offset: 0x001F7ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTraceNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x001F9CFB File Offset: 0x001F7EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x001F9D04 File Offset: 0x001F7F04
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A16 RID: 23062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A17 RID: 23063
		public const int MarkIdFieldNumber = 8;

		// Token: 0x04005A18 RID: 23064
		private int markId_;
	}
}
