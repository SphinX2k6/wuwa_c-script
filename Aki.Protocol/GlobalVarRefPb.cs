using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F9 RID: 1785
	public sealed class GlobalVarRefPb : IMessage<GlobalVarRefPb>, IMessage, IEquatable<GlobalVarRefPb>, IDeepCloneable<GlobalVarRefPb>, IBufferMessage
	{
		// Token: 0x0600A29D RID: 41629 RVA: 0x00189310 File Offset: 0x00187510
		[NullableContext(1)]
		public static GlobalVarRefPb Create()
		{
			return new GlobalVarRefPb();
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600A29E RID: 41630 RVA: 0x00189317 File Offset: 0x00187517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x0018931A File Offset: 0x0018751A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalVarRefPb.Descriptor;
			}
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00189321 File Offset: 0x00187521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb()
		{
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00189334 File Offset: 0x00187534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb(GlobalVarRefPb other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x00189359 File Offset: 0x00187559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb Clone()
		{
			return new GlobalVarRefPb(this);
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x00189361 File Offset: 0x00187561
		// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x00189369 File Offset: 0x00187569
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

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x0018937C File Offset: 0x0018757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalVarRefPb);
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x0018938A File Offset: 0x0018758A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GlobalVarRefPb other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x001893C0 File Offset: 0x001875C0
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

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x00189401 File Offset: 0x00187601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x0018940E File Offset: 0x0018760E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x00189417 File Offset: 0x00187617
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

		// Token: 0x0600A2AB RID: 41643 RVA: 0x00189450 File Offset: 0x00187650
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

		// Token: 0x0600A2AC RID: 41644 RVA: 0x00189493 File Offset: 0x00187693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GlobalVarRefPb other)
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

		// Token: 0x0600A2AD RID: 41645 RVA: 0x001894C9 File Offset: 0x001876C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x001894D4 File Offset: 0x001876D4
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

		// Token: 0x04004B52 RID: 19282
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B53 RID: 19283
		public const int NameFieldNumber = 1;

		// Token: 0x04004B54 RID: 19284
		private string name_ = "";
	}
}
