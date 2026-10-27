using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E0 RID: 736
	public sealed class ConstVarRefPb : IMessage<ConstVarRefPb>, IMessage, IEquatable<ConstVarRefPb>, IDeepCloneable<ConstVarRefPb>, IBufferMessage
	{
		// Token: 0x06004B07 RID: 19207 RVA: 0x000B6FC0 File Offset: 0x000B51C0
		[NullableContext(1)]
		public static ConstVarRefPb Create()
		{
			return new ConstVarRefPb();
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x000B6FC7 File Offset: 0x000B51C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06004B09 RID: 19209 RVA: 0x000B6FCA File Offset: 0x000B51CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConstVarRefPb.Descriptor;
			}
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x000B6FD1 File Offset: 0x000B51D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb()
		{
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x000B6FD9 File Offset: 0x000B51D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb(ConstVarRefPb other) : this()
		{
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x000B700E File Offset: 0x000B520E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb Clone()
		{
			return new ConstVarRefPb(this);
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x000B7016 File Offset: 0x000B5216
		// (set) Token: 0x06004B0E RID: 19214 RVA: 0x000B701E File Offset: 0x000B521E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x000B7027 File Offset: 0x000B5227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConstVarRefPb);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x000B7035 File Offset: 0x000B5235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConstVarRefPb other)
		{
			return other != null && (other == this || (object.Equals(this.Value, other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x000B7068 File Offset: 0x000B5268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.value_ != null)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x000B70A4 File Offset: 0x000B52A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x000B70B1 File Offset: 0x000B52B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x000B70BA File Offset: 0x000B52BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.value_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x000B70EC File Offset: 0x000B52EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.value_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x000B712C File Offset: 0x000B532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConstVarRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.value_ != null)
			{
				if (this.value_ == null)
				{
					this.Value = new VarDefinePb();
				}
				this.Value.MergeFrom(other.Value);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x000B7180 File Offset: 0x000B5380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x000B718C File Offset: 0x000B538C
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
					if (this.value_ == null)
					{
						this.Value = new VarDefinePb();
					}
					input.ReadMessage(this.Value);
				}
			}
		}

		// Token: 0x0400309C RID: 12444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400309D RID: 12445
		public const int ValueFieldNumber = 1;

		// Token: 0x0400309E RID: 12446
		private VarDefinePb value_;
	}
}
