using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000687 RID: 1671
	public sealed class GachaRecord0612RedisPb : IMessage<GachaRecord0612RedisPb>, IMessage, IEquatable<GachaRecord0612RedisPb>, IDeepCloneable<GachaRecord0612RedisPb>, IBufferMessage
	{
		// Token: 0x06009982 RID: 39298 RVA: 0x001730DF File Offset: 0x001712DF
		[NullableContext(1)]
		public static GachaRecord0612RedisPb Create()
		{
			return new GachaRecord0612RedisPb();
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06009983 RID: 39299 RVA: 0x001730E6 File Offset: 0x001712E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06009984 RID: 39300 RVA: 0x001730E9 File Offset: 0x001712E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRecord0612RedisPb.Descriptor;
			}
		}

		// Token: 0x06009985 RID: 39301 RVA: 0x001730F0 File Offset: 0x001712F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord0612RedisPb()
		{
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x00173103 File Offset: 0x00171303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord0612RedisPb(GachaRecord0612RedisPb other) : this()
		{
			this.itemTimes_ = other.itemTimes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x0017312D File Offset: 0x0017132D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord0612RedisPb Clone()
		{
			return new GachaRecord0612RedisPb(this);
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06009988 RID: 39304 RVA: 0x00173135 File Offset: 0x00171335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemTimes
		{
			get
			{
				return this.itemTimes_;
			}
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x0017313D File Offset: 0x0017133D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRecord0612RedisPb);
		}

		// Token: 0x0600998A RID: 39306 RVA: 0x0017314B File Offset: 0x0017134B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRecord0612RedisPb other)
		{
			return other != null && (other == this || (this.ItemTimes.Equals(other.ItemTimes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600998B RID: 39307 RVA: 0x00173180 File Offset: 0x00171380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ItemTimes.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600998C RID: 39308 RVA: 0x001731B4 File Offset: 0x001713B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x001731C1 File Offset: 0x001713C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x001731CA File Offset: 0x001713CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemTimes_.WriteTo(ref output, GachaRecord0612RedisPb._map_itemTimes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x001731F4 File Offset: 0x001713F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemTimes_.CalculateSize(GachaRecord0612RedisPb._map_itemTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x0017322D File Offset: 0x0017142D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRecord0612RedisPb other)
		{
			if (other == null)
			{
				return;
			}
			this.itemTimes_.MergeFrom(other.itemTimes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009991 RID: 39313 RVA: 0x0017325B File Offset: 0x0017145B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009992 RID: 39314 RVA: 0x00173264 File Offset: 0x00171464
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemTimes_.AddEntriesFrom(ref input, GachaRecord0612RedisPb._map_itemTimes_codec);
				}
			}
		}

		// Token: 0x04004931 RID: 18737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004932 RID: 18738
		public const int ItemTimesFieldNumber = 1;

		// Token: 0x04004933 RID: 18739
		private static readonly MapField<int, int>.Codec _map_itemTimes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04004934 RID: 18740
		private readonly MapField<int, int> itemTimes_ = new MapField<int, int>();
	}
}
