using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C4 RID: 4548
	public sealed class SelfVarRefPb : IMessage<SelfVarRefPb>, IMessage, IEquatable<SelfVarRefPb>, IDeepCloneable<SelfVarRefPb>, IBufferMessage
	{
		// Token: 0x0601843C RID: 99388 RVA: 0x003882A9 File Offset: 0x003864A9
		[NullableContext(1)]
		public static SelfVarRefPb Create()
		{
			return new SelfVarRefPb();
		}

		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x0601843D RID: 99389 RVA: 0x003882B0 File Offset: 0x003864B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x0601843E RID: 99390 RVA: 0x003882B3 File Offset: 0x003864B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelfVarRefPb.Descriptor;
			}
		}

		// Token: 0x0601843F RID: 99391 RVA: 0x003882BA File Offset: 0x003864BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb()
		{
		}

		// Token: 0x06018440 RID: 99392 RVA: 0x003882CD File Offset: 0x003864CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb(SelfVarRefPb other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018441 RID: 99393 RVA: 0x003882F2 File Offset: 0x003864F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb Clone()
		{
			return new SelfVarRefPb(this);
		}

		// Token: 0x170051BF RID: 20927
		// (get) Token: 0x06018442 RID: 99394 RVA: 0x003882FA File Offset: 0x003864FA
		// (set) Token: 0x06018443 RID: 99395 RVA: 0x00388302 File Offset: 0x00386502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06018444 RID: 99396 RVA: 0x00388315 File Offset: 0x00386515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelfVarRefPb);
		}

		// Token: 0x06018445 RID: 99397 RVA: 0x00388323 File Offset: 0x00386523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelfVarRefPb other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018446 RID: 99398 RVA: 0x00388358 File Offset: 0x00386558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018447 RID: 99399 RVA: 0x00388399 File Offset: 0x00386599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018448 RID: 99400 RVA: 0x003883A6 File Offset: 0x003865A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018449 RID: 99401 RVA: 0x003883AF File Offset: 0x003865AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601844A RID: 99402 RVA: 0x003883E8 File Offset: 0x003865E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601844B RID: 99403 RVA: 0x0038842B File Offset: 0x0038662B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelfVarRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601844C RID: 99404 RVA: 0x00388461 File Offset: 0x00386661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601844D RID: 99405 RVA: 0x0038846C File Offset: 0x0038666C
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
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04008FD0 RID: 36816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FD1 RID: 36817
		public const int NameFieldNumber = 1;

		// Token: 0x04008FD2 RID: 36818
		private string name_ = "";
	}
}
