using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001388 RID: 5000
	[NetMessage(EMessageId.TopPhantomEquipGroupRequest)]
	public sealed class TopPhantomEquipGroupRequest : IMessage<TopPhantomEquipGroupRequest>, IMessage, IEquatable<TopPhantomEquipGroupRequest>, IDeepCloneable<TopPhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x0601A89B RID: 108699 RVA: 0x003D9CF0 File Offset: 0x003D7EF0
		[NullableContext(1)]
		public static TopPhantomEquipGroupRequest Create()
		{
			return new TopPhantomEquipGroupRequest();
		}

		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x0601A89C RID: 108700 RVA: 0x003D9CF7 File Offset: 0x003D7EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x0601A89D RID: 108701 RVA: 0x003D9CFA File Offset: 0x003D7EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TopPhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601A89E RID: 108702 RVA: 0x003D9D01 File Offset: 0x003D7F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupRequest()
		{
		}

		// Token: 0x0601A89F RID: 108703 RVA: 0x003D9D09 File Offset: 0x003D7F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupRequest(TopPhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8A0 RID: 108704 RVA: 0x003D9D2E File Offset: 0x003D7F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupRequest Clone()
		{
			return new TopPhantomEquipGroupRequest(this);
		}

		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x0601A8A1 RID: 108705 RVA: 0x003D9D36 File Offset: 0x003D7F36
		// (set) Token: 0x0601A8A2 RID: 108706 RVA: 0x003D9D3E File Offset: 0x003D7F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601A8A3 RID: 108707 RVA: 0x003D9D47 File Offset: 0x003D7F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TopPhantomEquipGroupRequest);
		}

		// Token: 0x0601A8A4 RID: 108708 RVA: 0x003D9D55 File Offset: 0x003D7F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TopPhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8A5 RID: 108709 RVA: 0x003D9D84 File Offset: 0x003D7F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8A6 RID: 108710 RVA: 0x003D9DC3 File Offset: 0x003D7FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8A7 RID: 108711 RVA: 0x003D9DD0 File Offset: 0x003D7FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8A8 RID: 108712 RVA: 0x003D9DD9 File Offset: 0x003D7FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8A9 RID: 108713 RVA: 0x003D9E0C File Offset: 0x003D800C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8AA RID: 108714 RVA: 0x003D9E4A File Offset: 0x003D804A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TopPhantomEquipGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8AB RID: 108715 RVA: 0x003D9E7B File Offset: 0x003D807B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8AC RID: 108716 RVA: 0x003D9E84 File Offset: 0x003D8084
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A51 RID: 39505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A52 RID: 39506
		public const int IndexFieldNumber = 11;

		// Token: 0x04009A53 RID: 39507
		private int index_;
	}
}
