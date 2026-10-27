using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002AA RID: 682
	public sealed class ClientTriggerActionCtxPb : IMessage<ClientTriggerActionCtxPb>, IMessage, IEquatable<ClientTriggerActionCtxPb>, IDeepCloneable<ClientTriggerActionCtxPb>, IBufferMessage
	{
		// Token: 0x060046B3 RID: 18099 RVA: 0x000ADAB1 File Offset: 0x000ABCB1
		[NullableContext(1)]
		public static ClientTriggerActionCtxPb Create()
		{
			return new ClientTriggerActionCtxPb();
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x000ADAB8 File Offset: 0x000ABCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x000ADABB File Offset: 0x000ABCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientTriggerActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x000ADAC2 File Offset: 0x000ABCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb()
		{
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x000ADACC File Offset: 0x000ABCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb(ClientTriggerActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x000ADB18 File Offset: 0x000ABD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerActionCtxPb Clone()
		{
			return new ClientTriggerActionCtxPb(this);
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x000ADB20 File Offset: 0x000ABD20
		// (set) Token: 0x060046BA RID: 18106 RVA: 0x000ADB28 File Offset: 0x000ABD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x000ADB31 File Offset: 0x000ABD31
		// (set) Token: 0x060046BC RID: 18108 RVA: 0x000ADB39 File Offset: 0x000ABD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x000ADB42 File Offset: 0x000ABD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientTriggerActionCtxPb);
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x000ADB50 File Offset: 0x000ABD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientTriggerActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x000ADBA0 File Offset: 0x000ABDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x000ADBF5 File Offset: 0x000ABDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x000ADC02 File Offset: 0x000ABE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x000ADC0C File Offset: 0x000ABE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x000ADC68 File Offset: 0x000ABE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x000ADCB4 File Offset: 0x000ABEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientTriggerActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x000ADD1C File Offset: 0x000ABF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000ADD28 File Offset: 0x000ABF28
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsEnter = input.ReadBool();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04002F61 RID: 12129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F62 RID: 12130
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04002F63 RID: 12131
		private EntityCtxPb entityCtx_;

		// Token: 0x04002F64 RID: 12132
		public const int IsEnterFieldNumber = 2;

		// Token: 0x04002F65 RID: 12133
		private bool isEnter_;
	}
}
