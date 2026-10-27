using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2F RID: 2863
	public sealed class NewTowerClimbingCtx : IMessage<NewTowerClimbingCtx>, IMessage, IEquatable<NewTowerClimbingCtx>, IDeepCloneable<NewTowerClimbingCtx>, IBufferMessage
	{
		// Token: 0x0600F885 RID: 63621 RVA: 0x00243EF0 File Offset: 0x002420F0
		[NullableContext(1)]
		public static NewTowerClimbingCtx Create()
		{
			return new NewTowerClimbingCtx();
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600F886 RID: 63622 RVA: 0x00243EF7 File Offset: 0x002420F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600F887 RID: 63623 RVA: 0x00243EFA File Offset: 0x002420FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClimbingCtx.Descriptor;
			}
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x00243F01 File Offset: 0x00242101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx()
		{
		}

		// Token: 0x0600F889 RID: 63625 RVA: 0x00243F09 File Offset: 0x00242109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx(NewTowerClimbingCtx other) : this()
		{
			this.param_ = ((other.param_ != null) ? other.param_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F88A RID: 63626 RVA: 0x00243F3E File Offset: 0x0024213E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingCtx Clone()
		{
			return new NewTowerClimbingCtx(this);
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600F88B RID: 63627 RVA: 0x00243F46 File Offset: 0x00242146
		// (set) Token: 0x0600F88C RID: 63628 RVA: 0x00243F4E File Offset: 0x0024214E
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

		// Token: 0x0600F88D RID: 63629 RVA: 0x00243F57 File Offset: 0x00242157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClimbingCtx);
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x00243F65 File Offset: 0x00242165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClimbingCtx other)
		{
			return other != null && (other == this || (object.Equals(this.Param, other.Param) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F88F RID: 63631 RVA: 0x00243F98 File Offset: 0x00242198
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

		// Token: 0x0600F890 RID: 63632 RVA: 0x00243FD4 File Offset: 0x002421D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x00243FE1 File Offset: 0x002421E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x00243FEA File Offset: 0x002421EA
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

		// Token: 0x0600F893 RID: 63635 RVA: 0x0024401C File Offset: 0x0024221C
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

		// Token: 0x0600F894 RID: 63636 RVA: 0x0024405C File Offset: 0x0024225C
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

		// Token: 0x0600F895 RID: 63637 RVA: 0x002440B0 File Offset: 0x002422B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F896 RID: 63638 RVA: 0x002440BC File Offset: 0x002422BC
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

		// Token: 0x040063A7 RID: 25511
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063A8 RID: 25512
		public const int ParamFieldNumber = 1;

		// Token: 0x040063A9 RID: 25513
		private NewTowerCycleStartParam param_;
	}
}
