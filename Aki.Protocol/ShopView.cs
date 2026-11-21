using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001238 RID: 4664
	public sealed class ShopView : IMessage<ShopView>, IMessage, IEquatable<ShopView>, IDeepCloneable<ShopView>, IBufferMessage
	{
		// Token: 0x06018E95 RID: 102037 RVA: 0x003A1CEA File Offset: 0x0039FEEA
		[NullableContext(1)]
		public static ShopView Create()
		{
			return new ShopView();
		}

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x06018E96 RID: 102038 RVA: 0x003A1CF1 File Offset: 0x0039FEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x06018E97 RID: 102039 RVA: 0x003A1CF4 File Offset: 0x0039FEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopView.Descriptor;
			}
		}

		// Token: 0x06018E98 RID: 102040 RVA: 0x003A1CFB File Offset: 0x0039FEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView()
		{
		}

		// Token: 0x06018E99 RID: 102041 RVA: 0x003A1D03 File Offset: 0x0039FF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView(ShopView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E9A RID: 102042 RVA: 0x003A1D38 File Offset: 0x0039FF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopView Clone()
		{
			return new ShopView(this);
		}

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x06018E9B RID: 102043 RVA: 0x003A1D40 File Offset: 0x0039FF40
		// (set) Token: 0x06018E9C RID: 102044 RVA: 0x003A1D48 File Offset: 0x0039FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOption SurvivorsOption
		{
			get
			{
				return this.survivorsOption_;
			}
			set
			{
				this.survivorsOption_ = value;
			}
		}

		// Token: 0x06018E9D RID: 102045 RVA: 0x003A1D51 File Offset: 0x0039FF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopView);
		}

		// Token: 0x06018E9E RID: 102046 RVA: 0x003A1D5F File Offset: 0x0039FF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E9F RID: 102047 RVA: 0x003A1D94 File Offset: 0x0039FF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.survivorsOption_ != null)
			{
				num ^= this.SurvivorsOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018EA0 RID: 102048 RVA: 0x003A1DD0 File Offset: 0x0039FFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EA1 RID: 102049 RVA: 0x003A1DDD File Offset: 0x0039FFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EA2 RID: 102050 RVA: 0x003A1DE6 File Offset: 0x0039FFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.survivorsOption_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018EA3 RID: 102051 RVA: 0x003A1E18 File Offset: 0x003A0018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.survivorsOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018EA4 RID: 102052 RVA: 0x003A1E58 File Offset: 0x003A0058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.survivorsOption_ != null)
			{
				if (this.survivorsOption_ == null)
				{
					this.SurvivorsOption = new SurvivorsOption();
				}
				this.SurvivorsOption.MergeFrom(other.SurvivorsOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018EA5 RID: 102053 RVA: 0x003A1EAC File Offset: 0x003A00AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EA6 RID: 102054 RVA: 0x003A1EB8 File Offset: 0x003A00B8
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
					if (this.survivorsOption_ == null)
					{
						this.SurvivorsOption = new SurvivorsOption();
					}
					input.ReadMessage(this.SurvivorsOption);
				}
			}
		}

		// Token: 0x040093C8 RID: 37832
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093C9 RID: 37833
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x040093CA RID: 37834
		private SurvivorsOption survivorsOption_;
	}
}
