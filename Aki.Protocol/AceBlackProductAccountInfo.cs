using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000058 RID: 88
	public sealed class AceBlackProductAccountInfo : IMessage<AceBlackProductAccountInfo>, IMessage, IEquatable<AceBlackProductAccountInfo>, IDeepCloneable<AceBlackProductAccountInfo>, IBufferMessage
	{
		// Token: 0x06001572 RID: 5490 RVA: 0x00038E19 File Offset: 0x00037019
		[NullableContext(1)]
		public static AceBlackProductAccountInfo Create()
		{
			return new AceBlackProductAccountInfo();
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00038E20 File Offset: 0x00037020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00038E23 File Offset: 0x00037023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceBlackProductAccountInfo.Descriptor;
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00038E2A File Offset: 0x0003702A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo()
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00038E3D File Offset: 0x0003703D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo(AceBlackProductAccountInfo other) : this()
		{
			this.tdmDeviceId_ = other.tdmDeviceId_;
			this.isRoot_ = other.isRoot_;
			this.isSimulator_ = other.isSimulator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00038E7A File Offset: 0x0003707A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBlackProductAccountInfo Clone()
		{
			return new AceBlackProductAccountInfo(this);
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00038E82 File Offset: 0x00037082
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00038E8A File Offset: 0x0003708A
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00038E9D File Offset: 0x0003709D
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00038EA5 File Offset: 0x000370A5
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00038EAE File Offset: 0x000370AE
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00038EB6 File Offset: 0x000370B6
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

		// Token: 0x0600157E RID: 5502 RVA: 0x00038EBF File Offset: 0x000370BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceBlackProductAccountInfo);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00038ED0 File Offset: 0x000370D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceBlackProductAccountInfo other)
		{
			return other != null && (other == this || (!(this.TdmDeviceId != other.TdmDeviceId) && this.IsRoot == other.IsRoot && this.IsSimulator == other.IsSimulator && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00038F30 File Offset: 0x00037130
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

		// Token: 0x06001581 RID: 5505 RVA: 0x00038FA3 File Offset: 0x000371A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00038FB0 File Offset: 0x000371B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00038FBC File Offset: 0x000371BC
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

		// Token: 0x06001584 RID: 5508 RVA: 0x00039038 File Offset: 0x00037238
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

		// Token: 0x06001585 RID: 5509 RVA: 0x00039094 File Offset: 0x00037294
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

		// Token: 0x06001586 RID: 5510 RVA: 0x000390FD File Offset: 0x000372FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00039108 File Offset: 0x00037308
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

		// Token: 0x0400209F RID: 8351
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A0 RID: 8352
		public const int TdmDeviceIdFieldNumber = 1;

		// Token: 0x040020A1 RID: 8353
		private string tdmDeviceId_ = "";

		// Token: 0x040020A2 RID: 8354
		public const int IsRootFieldNumber = 2;

		// Token: 0x040020A3 RID: 8355
		private bool isRoot_;

		// Token: 0x040020A4 RID: 8356
		public const int IsSimulatorFieldNumber = 3;

		// Token: 0x040020A5 RID: 8357
		private bool isSimulator_;
	}
}
