using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B3 RID: 5043
	[NetMessage(EMessageId.TowerDefenceSelfPassRequest)]
	public sealed class TowerDefenceSelfPassRequest : IMessage<TowerDefenceSelfPassRequest>, IMessage, IEquatable<TowerDefenceSelfPassRequest>, IDeepCloneable<TowerDefenceSelfPassRequest>, IBufferMessage
	{
		// Token: 0x0601AC18 RID: 109592 RVA: 0x003E1525 File Offset: 0x003DF725
		[NullableContext(1)]
		public static TowerDefenceSelfPassRequest Create()
		{
			return new TowerDefenceSelfPassRequest();
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x0601AC19 RID: 109593 RVA: 0x003E152C File Offset: 0x003DF72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x0601AC1A RID: 109594 RVA: 0x003E152F File Offset: 0x003DF72F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceSelfPassRequest.Descriptor;
			}
		}

		// Token: 0x0601AC1B RID: 109595 RVA: 0x003E1536 File Offset: 0x003DF736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassRequest()
		{
		}

		// Token: 0x0601AC1C RID: 109596 RVA: 0x003E153E File Offset: 0x003DF73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassRequest(TowerDefenceSelfPassRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC1D RID: 109597 RVA: 0x003E1563 File Offset: 0x003DF763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassRequest Clone()
		{
			return new TowerDefenceSelfPassRequest(this);
		}

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x0601AC1E RID: 109598 RVA: 0x003E156B File Offset: 0x003DF76B
		// (set) Token: 0x0601AC1F RID: 109599 RVA: 0x003E1573 File Offset: 0x003DF773
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

		// Token: 0x0601AC20 RID: 109600 RVA: 0x003E157C File Offset: 0x003DF77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceSelfPassRequest);
		}

		// Token: 0x0601AC21 RID: 109601 RVA: 0x003E158A File Offset: 0x003DF78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceSelfPassRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC22 RID: 109602 RVA: 0x003E15B8 File Offset: 0x003DF7B8
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

		// Token: 0x0601AC23 RID: 109603 RVA: 0x003E15F7 File Offset: 0x003DF7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC24 RID: 109604 RVA: 0x003E1604 File Offset: 0x003DF804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC25 RID: 109605 RVA: 0x003E160D File Offset: 0x003DF80D
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

		// Token: 0x0601AC26 RID: 109606 RVA: 0x003E1640 File Offset: 0x003DF840
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

		// Token: 0x0601AC27 RID: 109607 RVA: 0x003E167E File Offset: 0x003DF87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceSelfPassRequest other)
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

		// Token: 0x0601AC28 RID: 109608 RVA: 0x003E16AF File Offset: 0x003DF8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC29 RID: 109609 RVA: 0x003E16B8 File Offset: 0x003DF8B8
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

		// Token: 0x04009B5B RID: 39771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B5C RID: 39772
		public const int IdFieldNumber = 4;

		// Token: 0x04009B5D RID: 39773
		private int id_;
	}
}
