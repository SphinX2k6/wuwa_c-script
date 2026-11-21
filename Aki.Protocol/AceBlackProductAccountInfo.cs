using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000059 RID: 89
	public sealed class AceBlackProductAccountInfo : IMessage<AceBlackProductAccountInfo>, IMessage, IEquatable<AceBlackProductAccountInfo>, IDeepCloneable<AceBlackProductAccountInfo>, IBufferMessage
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x000397BD File Offset: 0x000379BD
		[NullableContext(1)]
		public static AceBlackProductAccountInfo Create()
		{
			return new AceBlackProductAccountInfo();
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x000397C4 File Offset: 0x000379C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000397C7 File Offset: 0x000379C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceBlackProductAccountInfo.Descriptor;
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000397CE File Offset: 0x000379CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000397E1 File Offset: 0x000379E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo(AceBlackProductAccountInfo other) : this()
		{
			this.tdmDeviceId_ = other.tdmDeviceId_;
			this.isRoot_ = other.isRoot_;
			this.isSimulator_ = other.isSimulator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0003981E File Offset: 0x00037A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo Clone()
		{
			return new AceBlackProductAccountInfo(this);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00039826 File Offset: 0x00037A26
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x0003982E File Offset: 0x00037A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TdmDeviceId
		{
			get
			{
				return this.tdmDeviceId_;
			}
			set
			{
				this.tdmDeviceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00039841 File Offset: 0x00037A41
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00039849 File Offset: 0x00037A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRoot
		{
			get
			{
				return this.isRoot_;
			}
			set
			{
				this.isRoot_ = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00039852 File Offset: 0x00037A52
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x0003985A File Offset: 0x00037A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSimulator
		{
			get
			{
				return this.isSimulator_;
			}
			set
			{
				this.isSimulator_ = value;
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00039863 File Offset: 0x00037A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceBlackProductAccountInfo);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00039874 File Offset: 0x00037A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceBlackProductAccountInfo other)
		{
			return other != null && (other == this || (!(this.TdmDeviceId != other.TdmDeviceId) && this.IsRoot == other.IsRoot && this.IsSimulator == other.IsSimulator && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000398D4 File Offset: 0x00037AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TdmDeviceId.Length != 0)
			{
				num ^= this.TdmDeviceId.GetHashCode();
			}
			if (this.IsRoot)
			{
				num ^= this.IsRoot.GetHashCode();
			}
			if (this.IsSimulator)
			{
				num ^= this.IsSimulator.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00039947 File Offset: 0x00037B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00039954 File Offset: 0x00037B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00039960 File Offset: 0x00037B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TdmDeviceId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TdmDeviceId);
			}
			if (this.IsRoot)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsRoot);
			}
			if (this.IsSimulator)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSimulator);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000399DC File Offset: 0x00037BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TdmDeviceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TdmDeviceId);
			}
			if (this.IsRoot)
			{
				num += 2;
			}
			if (this.IsSimulator)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00039A38 File Offset: 0x00037C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AceBlackProductAccountInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TdmDeviceId.Length != 0)
			{
				this.TdmDeviceId = other.TdmDeviceId;
			}
			if (other.IsRoot)
			{
				this.IsRoot = other.IsRoot;
			}
			if (other.IsSimulator)
			{
				this.IsSimulator = other.IsSimulator;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00039AA1 File Offset: 0x00037CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00039AAC File Offset: 0x00037CAC
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsSimulator = input.ReadBool();
						}
					}
					else
					{
						this.IsRoot = input.ReadBool();
					}
				}
				else
				{
					this.TdmDeviceId = input.ReadString();
				}
			}
		}

		// Token: 0x040020FE RID: 8446
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020FF RID: 8447
		public const int TdmDeviceIdFieldNumber = 1;

		// Token: 0x04002100 RID: 8448
		private string tdmDeviceId_ = "";

		// Token: 0x04002101 RID: 8449
		public const int IsRootFieldNumber = 2;

		// Token: 0x04002102 RID: 8450
		private bool isRoot_;

		// Token: 0x04002103 RID: 8451
		public const int IsSimulatorFieldNumber = 3;

		// Token: 0x04002104 RID: 8452
		private bool isSimulator_;
	}
}
