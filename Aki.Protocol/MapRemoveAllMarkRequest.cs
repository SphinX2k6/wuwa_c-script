using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000991 RID: 2449
	[NetMessage(EMessageId.MapRemoveAllMarkRequest)]
	public sealed class MapRemoveAllMarkRequest : IMessage<MapRemoveAllMarkRequest>, IMessage, IEquatable<MapRemoveAllMarkRequest>, IDeepCloneable<MapRemoveAllMarkRequest>, IBufferMessage
	{
		// Token: 0x0600D73E RID: 55102 RVA: 0x001FA711 File Offset: 0x001F8911
		[NullableContext(1)]
		public static MapRemoveAllMarkRequest Create()
		{
			return new MapRemoveAllMarkRequest();
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0600D73F RID: 55103 RVA: 0x001FA718 File Offset: 0x001F8918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0600D740 RID: 55104 RVA: 0x001FA71B File Offset: 0x001F891B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapRemoveAllMarkRequest.Descriptor;
			}
		}

		// Token: 0x0600D741 RID: 55105 RVA: 0x001FA722 File Offset: 0x001F8922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkRequest()
		{
		}

		// Token: 0x0600D742 RID: 55106 RVA: 0x001FA72A File Offset: 0x001F892A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkRequest(MapRemoveAllMarkRequest other) : this()
		{
			this.markType_ = other.markType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D743 RID: 55107 RVA: 0x001FA74F File Offset: 0x001F894F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapRemoveAllMarkRequest Clone()
		{
			return new MapRemoveAllMarkRequest(this);
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0600D744 RID: 55108 RVA: 0x001FA757 File Offset: 0x001F8957
		// (set) Token: 0x0600D745 RID: 55109 RVA: 0x001FA75F File Offset: 0x001F895F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkType
		{
			get
			{
				return this.markType_;
			}
			set
			{
				this.markType_ = value;
			}
		}

		// Token: 0x0600D746 RID: 55110 RVA: 0x001FA768 File Offset: 0x001F8968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapRemoveAllMarkRequest);
		}

		// Token: 0x0600D747 RID: 55111 RVA: 0x001FA776 File Offset: 0x001F8976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapRemoveAllMarkRequest other)
		{
			return other != null && (other == this || (this.MarkType == other.MarkType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D748 RID: 55112 RVA: 0x001FA7A4 File Offset: 0x001F89A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkType != 0)
			{
				num ^= this.MarkType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D749 RID: 55113 RVA: 0x001FA7E3 File Offset: 0x001F89E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D74A RID: 55114 RVA: 0x001FA7F0 File Offset: 0x001F89F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D74B RID: 55115 RVA: 0x001FA7F9 File Offset: 0x001F89F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D74C RID: 55116 RVA: 0x001FA82C File Offset: 0x001F8A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D74D RID: 55117 RVA: 0x001FA86A File Offset: 0x001F8A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapRemoveAllMarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkType != 0)
			{
				this.MarkType = other.MarkType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D74E RID: 55118 RVA: 0x001FA89B File Offset: 0x001F8A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D74F RID: 55119 RVA: 0x001FA8A4 File Offset: 0x001F8AA4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MarkType = input.ReadInt32();
				}
			}
		}

		// Token: 0x040059DF RID: 23007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E0 RID: 23008
		public const int MarkTypeFieldNumber = 5;

		// Token: 0x040059E1 RID: 23009
		private int markType_;
	}
}
