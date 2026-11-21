using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C5 RID: 1477
	public sealed class FloroRanchRefreshCost : IMessage<FloroRanchRefreshCost>, IMessage, IEquatable<FloroRanchRefreshCost>, IDeepCloneable<FloroRanchRefreshCost>, IBufferMessage
	{
		// Token: 0x06008935 RID: 35125 RVA: 0x0014C6EA File Offset: 0x0014A8EA
		[NullableContext(1)]
		public static FloroRanchRefreshCost Create()
		{
			return new FloroRanchRefreshCost();
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06008936 RID: 35126 RVA: 0x0014C6F1 File Offset: 0x0014A8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchRefreshCost> Parser
		{
			get
			{
				return FloroRanchRefreshCost._parser;
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x0014C6F8 File Offset: 0x0014A8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06008938 RID: 35128 RVA: 0x0014C6FB File Offset: 0x0014A8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRefreshCost.Descriptor;
			}
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x0014C702 File Offset: 0x0014A902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRefreshCost()
		{
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x0014C70A File Offset: 0x0014A90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRefreshCost(FloroRanchRefreshCost other) : this()
		{
			this.type_ = other.type_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x0014C73B File Offset: 0x0014A93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRefreshCost Clone()
		{
			return new FloroRanchRefreshCost(this);
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x0600893C RID: 35132 RVA: 0x0014C743 File Offset: 0x0014A943
		// (set) Token: 0x0600893D RID: 35133 RVA: 0x0014C74B File Offset: 0x0014A94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayResourcesType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x0600893E RID: 35134 RVA: 0x0014C754 File Offset: 0x0014A954
		// (set) Token: 0x0600893F RID: 35135 RVA: 0x0014C75C File Offset: 0x0014A95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x0014C765 File Offset: 0x0014A965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRefreshCost);
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0014C773 File Offset: 0x0014A973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRefreshCost other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x0014C7B4 File Offset: 0x0014A9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FloroRanchPlayResourcesType.Coin)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x0014C812 File Offset: 0x0014AA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x0014C81F File Offset: 0x0014AA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x0014C828 File Offset: 0x0014AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FloroRanchPlayResourcesType.Coin)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x0014C880 File Offset: 0x0014AA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FloroRanchPlayResourcesType.Coin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x0014C8D8 File Offset: 0x0014AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRefreshCost other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FloroRanchPlayResourcesType.Coin)
			{
				this.Type = other.Type;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x0014C928 File Offset: 0x0014AB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x0014C934 File Offset: 0x0014AB34
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (FloroRanchPlayResourcesType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004407 RID: 17415
		private static readonly MessageParser<FloroRanchRefreshCost> _parser = new MessageParser<FloroRanchRefreshCost>(() => new FloroRanchRefreshCost());

		// Token: 0x04004408 RID: 17416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004409 RID: 17417
		public const int TypeFieldNumber = 1;

		// Token: 0x0400440A RID: 17418
		private FloroRanchPlayResourcesType type_;

		// Token: 0x0400440B RID: 17419
		public const int CountFieldNumber = 2;

		// Token: 0x0400440C RID: 17420
		private int count_;
	}
}
