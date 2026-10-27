using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000990 RID: 2448
	[NetMessage(EMessageId.MapOpenPush)]
	public sealed class MapOpenPush : IMessage<MapOpenPush>, IMessage, IEquatable<MapOpenPush>, IDeepCloneable<MapOpenPush>, IBufferMessage
	{
		// Token: 0x0600D72C RID: 55084 RVA: 0x001FA52F File Offset: 0x001F872F
		[NullableContext(1)]
		public static MapOpenPush Create()
		{
			return new MapOpenPush();
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x0600D72D RID: 55085 RVA: 0x001FA536 File Offset: 0x001F8736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x0600D72E RID: 55086 RVA: 0x001FA539 File Offset: 0x001F8739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapOpenPush.Descriptor;
			}
		}

		// Token: 0x0600D72F RID: 55087 RVA: 0x001FA540 File Offset: 0x001F8740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenPush()
		{
		}

		// Token: 0x0600D730 RID: 55088 RVA: 0x001FA548 File Offset: 0x001F8748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenPush(MapOpenPush other) : this()
		{
			this.openType_ = other.openType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x001FA56D File Offset: 0x001F876D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenPush Clone()
		{
			return new MapOpenPush(this);
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0600D732 RID: 55090 RVA: 0x001FA575 File Offset: 0x001F8775
		// (set) Token: 0x0600D733 RID: 55091 RVA: 0x001FA57D File Offset: 0x001F877D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapOpenType OpenType
		{
			get
			{
				return this.openType_;
			}
			set
			{
				this.openType_ = value;
			}
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x001FA586 File Offset: 0x001F8786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapOpenPush);
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x001FA594 File Offset: 0x001F8794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapOpenPush other)
		{
			return other != null && (other == this || (this.OpenType == other.OpenType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D736 RID: 55094 RVA: 0x001FA5C4 File Offset: 0x001F87C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpenType != MapOpenType.HotKey)
			{
				num ^= this.OpenType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D737 RID: 55095 RVA: 0x001FA609 File Offset: 0x001F8809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x001FA616 File Offset: 0x001F8816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x001FA61F File Offset: 0x001F881F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpenType != MapOpenType.HotKey)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.OpenType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x001FA654 File Offset: 0x001F8854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpenType != MapOpenType.HotKey)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpenType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x001FA692 File Offset: 0x001F8892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapOpenPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpenType != MapOpenType.HotKey)
			{
				this.OpenType = other.OpenType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D73C RID: 55100 RVA: 0x001FA6C3 File Offset: 0x001F88C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D73D RID: 55101 RVA: 0x001FA6CC File Offset: 0x001F88CC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OpenType = (MapOpenType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040059DC RID: 23004
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059DD RID: 23005
		public const int OpenTypeFieldNumber = 3;

		// Token: 0x040059DE RID: 23006
		private MapOpenType openType_;
	}
}
