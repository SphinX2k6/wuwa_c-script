using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E5 RID: 1765
	public sealed class GlobalVarRefPb : IMessage<GlobalVarRefPb>, IMessage, IEquatable<GlobalVarRefPb>, IDeepCloneable<GlobalVarRefPb>, IBufferMessage
	{
		// Token: 0x0600A147 RID: 41287 RVA: 0x001868DC File Offset: 0x00184ADC
		[NullableContext(1)]
		public static GlobalVarRefPb Create()
		{
			return new GlobalVarRefPb();
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600A148 RID: 41288 RVA: 0x001868E3 File Offset: 0x00184AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x001868E6 File Offset: 0x00184AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalVarRefPb.Descriptor;
			}
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x001868ED File Offset: 0x00184AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb()
		{
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x00186900 File Offset: 0x00184B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb(GlobalVarRefPb other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x00186925 File Offset: 0x00184B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb Clone()
		{
			return new GlobalVarRefPb(this);
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600A14D RID: 41293 RVA: 0x0018692D File Offset: 0x00184B2D
		// (set) Token: 0x0600A14E RID: 41294 RVA: 0x00186935 File Offset: 0x00184B35
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

		// Token: 0x0600A14F RID: 41295 RVA: 0x00186948 File Offset: 0x00184B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalVarRefPb);
		}

		// Token: 0x0600A150 RID: 41296 RVA: 0x00186956 File Offset: 0x00184B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GlobalVarRefPb other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x0018698C File Offset: 0x00184B8C
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

		// Token: 0x0600A152 RID: 41298 RVA: 0x001869CD File Offset: 0x00184BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x001869DA File Offset: 0x00184BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x001869E3 File Offset: 0x00184BE3
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

		// Token: 0x0600A155 RID: 41301 RVA: 0x00186A1C File Offset: 0x00184C1C
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

		// Token: 0x0600A156 RID: 41302 RVA: 0x00186A5F File Offset: 0x00184C5F
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

		// Token: 0x0600A157 RID: 41303 RVA: 0x00186A95 File Offset: 0x00184C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x00186AA0 File Offset: 0x00184CA0
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

		// Token: 0x04004B4B RID: 19275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B4C RID: 19276
		public const int NameFieldNumber = 1;

		// Token: 0x04004B4D RID: 19277
		private string name_ = "";
	}
}
