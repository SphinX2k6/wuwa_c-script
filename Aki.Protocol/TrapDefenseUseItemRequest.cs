using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145D RID: 5213
	[NetMessage(EMessageId.TrapDefenseUseItemRequest)]
	public sealed class TrapDefenseUseItemRequest : IMessage<TrapDefenseUseItemRequest>, IMessage, IEquatable<TrapDefenseUseItemRequest>, IDeepCloneable<TrapDefenseUseItemRequest>, IBufferMessage
	{
		// Token: 0x0601B9A0 RID: 113056 RVA: 0x003FEBBC File Offset: 0x003FCDBC
		[NullableContext(1)]
		public static TrapDefenseUseItemRequest Create()
		{
			return new TrapDefenseUseItemRequest();
		}

		// Token: 0x17005D10 RID: 23824
		// (get) Token: 0x0601B9A1 RID: 113057 RVA: 0x003FEBC3 File Offset: 0x003FCDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D11 RID: 23825
		// (get) Token: 0x0601B9A2 RID: 113058 RVA: 0x003FEBC6 File Offset: 0x003FCDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseUseItemRequest.Descriptor;
			}
		}

		// Token: 0x0601B9A3 RID: 113059 RVA: 0x003FEBCD File Offset: 0x003FCDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemRequest()
		{
		}

		// Token: 0x0601B9A4 RID: 113060 RVA: 0x003FEBD5 File Offset: 0x003FCDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemRequest(TrapDefenseUseItemRequest other) : this()
		{
			this.itemConfigId_ = other.itemConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9A5 RID: 113061 RVA: 0x003FEBFA File Offset: 0x003FCDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemRequest Clone()
		{
			return new TrapDefenseUseItemRequest(this);
		}

		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x0601B9A6 RID: 113062 RVA: 0x003FEC02 File Offset: 0x003FCE02
		// (set) Token: 0x0601B9A7 RID: 113063 RVA: 0x003FEC0A File Offset: 0x003FCE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemConfigId
		{
			get
			{
				return this.itemConfigId_;
			}
			set
			{
				this.itemConfigId_ = value;
			}
		}

		// Token: 0x0601B9A8 RID: 113064 RVA: 0x003FEC13 File Offset: 0x003FCE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseUseItemRequest);
		}

		// Token: 0x0601B9A9 RID: 113065 RVA: 0x003FEC21 File Offset: 0x003FCE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseUseItemRequest other)
		{
			return other != null && (other == this || (this.ItemConfigId == other.ItemConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9AA RID: 113066 RVA: 0x003FEC50 File Offset: 0x003FCE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemConfigId != 0)
			{
				num ^= this.ItemConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9AB RID: 113067 RVA: 0x003FEC8F File Offset: 0x003FCE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9AC RID: 113068 RVA: 0x003FEC9C File Offset: 0x003FCE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9AD RID: 113069 RVA: 0x003FECA5 File Offset: 0x003FCEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemConfigId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9AE RID: 113070 RVA: 0x003FECD8 File Offset: 0x003FCED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9AF RID: 113071 RVA: 0x003FED16 File Offset: 0x003FCF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseUseItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemConfigId != 0)
			{
				this.ItemConfigId = other.ItemConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9B0 RID: 113072 RVA: 0x003FED47 File Offset: 0x003FCF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9B1 RID: 113073 RVA: 0x003FED50 File Offset: 0x003FCF50
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F12 RID: 40722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F13 RID: 40723
		public const int ItemConfigIdFieldNumber = 10;

		// Token: 0x04009F14 RID: 40724
		private int itemConfigId_;
	}
}
