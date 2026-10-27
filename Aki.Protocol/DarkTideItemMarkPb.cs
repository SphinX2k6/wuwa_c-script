using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A6 RID: 934
	public sealed class DarkTideItemMarkPb : IMessage<DarkTideItemMarkPb>, IMessage, IEquatable<DarkTideItemMarkPb>, IDeepCloneable<DarkTideItemMarkPb>, IBufferMessage
	{
		// Token: 0x06005BE3 RID: 23523 RVA: 0x000DF5E9 File Offset: 0x000DD7E9
		[NullableContext(1)]
		public static DarkTideItemMarkPb Create()
		{
			return new DarkTideItemMarkPb();
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x000DF5F0 File Offset: 0x000DD7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06005BE5 RID: 23525 RVA: 0x000DF5F3 File Offset: 0x000DD7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideItemMarkPb.Descriptor;
			}
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x000DF5FA File Offset: 0x000DD7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkPb()
		{
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x000DF602 File Offset: 0x000DD802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkPb(DarkTideItemMarkPb other) : this()
		{
			this.markPlayerId_ = other.markPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x000DF627 File Offset: 0x000DD827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkPb Clone()
		{
			return new DarkTideItemMarkPb(this);
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06005BE9 RID: 23529 RVA: 0x000DF62F File Offset: 0x000DD82F
		// (set) Token: 0x06005BEA RID: 23530 RVA: 0x000DF637 File Offset: 0x000DD837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkPlayerId
		{
			get
			{
				return this.markPlayerId_;
			}
			set
			{
				this.markPlayerId_ = value;
			}
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x000DF640 File Offset: 0x000DD840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideItemMarkPb);
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x000DF64E File Offset: 0x000DD84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideItemMarkPb other)
		{
			return other != null && (other == this || (this.MarkPlayerId == other.MarkPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x000DF67C File Offset: 0x000DD87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkPlayerId != 0)
			{
				num ^= this.MarkPlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x000DF6BB File Offset: 0x000DD8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x000DF6C8 File Offset: 0x000DD8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x000DF6D1 File Offset: 0x000DD8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkPlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MarkPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x000DF704 File Offset: 0x000DD904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkPlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x000DF742 File Offset: 0x000DD942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideItemMarkPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkPlayerId != 0)
			{
				this.MarkPlayerId = other.MarkPlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x000DF773 File Offset: 0x000DD973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x000DF77C File Offset: 0x000DD97C
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
					this.MarkPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003621 RID: 13857
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003622 RID: 13858
		public const int MarkPlayerIdFieldNumber = 1;

		// Token: 0x04003623 RID: 13859
		private int markPlayerId_;
	}
}
