using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C5 RID: 4293
	public sealed class RoleTowerCtx : IMessage<RoleTowerCtx>, IMessage, IEquatable<RoleTowerCtx>, IDeepCloneable<RoleTowerCtx>, IBufferMessage
	{
		// Token: 0x06016F1F RID: 93983 RVA: 0x003562A0 File Offset: 0x003544A0
		[NullableContext(1)]
		public static RoleTowerCtx Create()
		{
			return new RoleTowerCtx();
		}

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x06016F20 RID: 93984 RVA: 0x003562A7 File Offset: 0x003544A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x06016F21 RID: 93985 RVA: 0x003562AA File Offset: 0x003544AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerCtx.Descriptor;
			}
		}

		// Token: 0x06016F22 RID: 93986 RVA: 0x003562B1 File Offset: 0x003544B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerCtx()
		{
		}

		// Token: 0x06016F23 RID: 93987 RVA: 0x003562B9 File Offset: 0x003544B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerCtx(RoleTowerCtx other) : this()
		{
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F24 RID: 93988 RVA: 0x003562EE File Offset: 0x003544EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerCtx Clone()
		{
			return new RoleTowerCtx(this);
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x06016F25 RID: 93989 RVA: 0x003562F6 File Offset: 0x003544F6
		// (set) Token: 0x06016F26 RID: 93990 RVA: 0x003562FE File Offset: 0x003544FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerInstParam Param
		{
			get
			{
				return this.param_;
			}
			set
			{
				this.param_ = value;
			}
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x00356307 File Offset: 0x00354507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerCtx);
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x00356315 File Offset: 0x00354515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerCtx other)
		{
			return other != null && (other == this || (object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x00356348 File Offset: 0x00354548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.param_ != null)
			{
				num ^= this.Param.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x00356384 File Offset: 0x00354584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F2B RID: 93995 RVA: 0x00356391 File Offset: 0x00354591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F2C RID: 93996 RVA: 0x0035639A File Offset: 0x0035459A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.param_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Param);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F2D RID: 93997 RVA: 0x003563CC File Offset: 0x003545CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.param_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Param);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F2E RID: 93998 RVA: 0x0035640C File Offset: 0x0035460C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.param_ != null)
			{
				if (this.param_ == null)
				{
					this.Param = new RoleTowerInstParam();
				}
				this.Param.MergeFrom(other.Param);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F2F RID: 93999 RVA: 0x00356460 File Offset: 0x00354660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F30 RID: 94000 RVA: 0x0035646C File Offset: 0x0035466C
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
					if (this.param_ == null)
					{
						this.Param = new RoleTowerInstParam();
					}
					input.ReadMessage(this.Param);
				}
			}
		}

		// Token: 0x04008953 RID: 35155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008954 RID: 35156
		public const int ParamFieldNumber = 1;

		// Token: 0x04008955 RID: 35157
		private RoleTowerInstParam param_;
	}
}
