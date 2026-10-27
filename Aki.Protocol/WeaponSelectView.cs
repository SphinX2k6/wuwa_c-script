using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F8 RID: 5368
	public sealed class WeaponSelectView : IMessage<WeaponSelectView>, IMessage, IEquatable<WeaponSelectView>, IDeepCloneable<WeaponSelectView>, IBufferMessage
	{
		// Token: 0x0601C614 RID: 116244 RVA: 0x00419B02 File Offset: 0x00417D02
		[NullableContext(1)]
		public static WeaponSelectView Create()
		{
			return new WeaponSelectView();
		}

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x0601C615 RID: 116245 RVA: 0x00419B09 File Offset: 0x00417D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x0601C616 RID: 116246 RVA: 0x00419B0C File Offset: 0x00417D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSelectView.Descriptor;
			}
		}

		// Token: 0x0601C617 RID: 116247 RVA: 0x00419B13 File Offset: 0x00417D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView()
		{
		}

		// Token: 0x0601C618 RID: 116248 RVA: 0x00419B1B File Offset: 0x00417D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView(WeaponSelectView other) : this()
		{
			this.survivorsOption_ = ((other.survivorsOption_ != null) ? other.survivorsOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C619 RID: 116249 RVA: 0x00419B50 File Offset: 0x00417D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSelectView Clone()
		{
			return new WeaponSelectView(this);
		}

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x0601C61A RID: 116250 RVA: 0x00419B58 File Offset: 0x00417D58
		// (set) Token: 0x0601C61B RID: 116251 RVA: 0x00419B60 File Offset: 0x00417D60
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

		// Token: 0x0601C61C RID: 116252 RVA: 0x00419B69 File Offset: 0x00417D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSelectView);
		}

		// Token: 0x0601C61D RID: 116253 RVA: 0x00419B77 File Offset: 0x00417D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSelectView other)
		{
			return other != null && (other == this || (object.Equals(this.SurvivorsOption, other.SurvivorsOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C61E RID: 116254 RVA: 0x00419BAC File Offset: 0x00417DAC
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

		// Token: 0x0601C61F RID: 116255 RVA: 0x00419BE8 File Offset: 0x00417DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C620 RID: 116256 RVA: 0x00419BF5 File Offset: 0x00417DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C621 RID: 116257 RVA: 0x00419BFE File Offset: 0x00417DFE
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

		// Token: 0x0601C622 RID: 116258 RVA: 0x00419C30 File Offset: 0x00417E30
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

		// Token: 0x0601C623 RID: 116259 RVA: 0x00419C70 File Offset: 0x00417E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponSelectView other)
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

		// Token: 0x0601C624 RID: 116260 RVA: 0x00419CC4 File Offset: 0x00417EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C625 RID: 116261 RVA: 0x00419CD0 File Offset: 0x00417ED0
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

		// Token: 0x0400A292 RID: 41618
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A293 RID: 41619
		public const int SurvivorsOptionFieldNumber = 1;

		// Token: 0x0400A294 RID: 41620
		private SurvivorsOption survivorsOption_;
	}
}
