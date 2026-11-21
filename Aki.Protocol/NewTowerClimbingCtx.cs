using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1E RID: 2846
	public sealed class NewTowerClimbingCtx : IMessage<NewTowerClimbingCtx>, IMessage, IEquatable<NewTowerClimbingCtx>, IDeepCloneable<NewTowerClimbingCtx>, IBufferMessage
	{
		// Token: 0x0600F76B RID: 63339 RVA: 0x00241CD4 File Offset: 0x0023FED4
		[NullableContext(1)]
		public static NewTowerClimbingCtx Create()
		{
			return new NewTowerClimbingCtx();
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600F76C RID: 63340 RVA: 0x00241CDB File Offset: 0x0023FEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600F76D RID: 63341 RVA: 0x00241CDE File Offset: 0x0023FEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClimbingCtx.Descriptor;
			}
		}

		// Token: 0x0600F76E RID: 63342 RVA: 0x00241CE5 File Offset: 0x0023FEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx()
		{
		}

		// Token: 0x0600F76F RID: 63343 RVA: 0x00241CED File Offset: 0x0023FEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx(NewTowerClimbingCtx other) : this()
		{
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F770 RID: 63344 RVA: 0x00241D22 File Offset: 0x0023FF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx Clone()
		{
			return new NewTowerClimbingCtx(this);
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600F771 RID: 63345 RVA: 0x00241D2A File Offset: 0x0023FF2A
		// (set) Token: 0x0600F772 RID: 63346 RVA: 0x00241D32 File Offset: 0x0023FF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerCycleStartParam Param
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

		// Token: 0x0600F773 RID: 63347 RVA: 0x00241D3B File Offset: 0x0023FF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClimbingCtx);
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x00241D49 File Offset: 0x0023FF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClimbingCtx other)
		{
			return other != null && (other == this || (object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F775 RID: 63349 RVA: 0x00241D7C File Offset: 0x0023FF7C
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

		// Token: 0x0600F776 RID: 63350 RVA: 0x00241DB8 File Offset: 0x0023FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F777 RID: 63351 RVA: 0x00241DC5 File Offset: 0x0023FFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F778 RID: 63352 RVA: 0x00241DCE File Offset: 0x0023FFCE
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

		// Token: 0x0600F779 RID: 63353 RVA: 0x00241E00 File Offset: 0x00240000
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

		// Token: 0x0600F77A RID: 63354 RVA: 0x00241E40 File Offset: 0x00240040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerClimbingCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.param_ != null)
			{
				if (this.param_ == null)
				{
					this.Param = new NewTowerCycleStartParam();
				}
				this.Param.MergeFrom(other.Param);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F77B RID: 63355 RVA: 0x00241E94 File Offset: 0x00240094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F77C RID: 63356 RVA: 0x00241EA0 File Offset: 0x002400A0
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
						this.Param = new NewTowerCycleStartParam();
					}
					input.ReadMessage(this.Param);
				}
			}
		}

		// Token: 0x040063B0 RID: 25520
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063B1 RID: 25521
		public const int ParamFieldNumber = 1;

		// Token: 0x040063B2 RID: 25522
		private NewTowerCycleStartParam param_;
	}
}
