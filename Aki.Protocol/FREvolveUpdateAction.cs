using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000647 RID: 1607
	public sealed class FREvolveUpdateAction : IMessage<FREvolveUpdateAction>, IMessage, IEquatable<FREvolveUpdateAction>, IDeepCloneable<FREvolveUpdateAction>, IBufferMessage
	{
		// Token: 0x060093EB RID: 37867 RVA: 0x00165ABA File Offset: 0x00163CBA
		[NullableContext(1)]
		public static FREvolveUpdateAction Create()
		{
			return new FREvolveUpdateAction();
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060093EC RID: 37868 RVA: 0x00165AC1 File Offset: 0x00163CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060093ED RID: 37869 RVA: 0x00165AC4 File Offset: 0x00163CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FREvolveUpdateAction.Descriptor;
			}
		}

		// Token: 0x060093EE RID: 37870 RVA: 0x00165ACB File Offset: 0x00163CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction()
		{
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x00165AD4 File Offset: 0x00163CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction(FREvolveUpdateAction other) : this()
		{
			this.targetIncId_ = other.targetIncId_;
			this.newData_ = ((other.newData_ != null) ? other.newData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x00165B20 File Offset: 0x00163D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction Clone()
		{
			return new FREvolveUpdateAction(this);
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x060093F1 RID: 37873 RVA: 0x00165B28 File Offset: 0x00163D28
		// (set) Token: 0x060093F2 RID: 37874 RVA: 0x00165B30 File Offset: 0x00163D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetIncId
		{
			get
			{
				return this.targetIncId_;
			}
			set
			{
				this.targetIncId_ = value;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060093F3 RID: 37875 RVA: 0x00165B39 File Offset: 0x00163D39
		// (set) Token: 0x060093F4 RID: 37876 RVA: 0x00165B41 File Offset: 0x00163D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData NewData
		{
			get
			{
				return this.newData_;
			}
			set
			{
				this.newData_ = value;
			}
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x00165B4A File Offset: 0x00163D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FREvolveUpdateAction);
		}

		// Token: 0x060093F6 RID: 37878 RVA: 0x00165B58 File Offset: 0x00163D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FREvolveUpdateAction other)
		{
			return other != null && (other == this || (this.TargetIncId == other.TargetIncId && object.Equals(this.NewData, other.NewData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x00165BA8 File Offset: 0x00163DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetIncId != 0)
			{
				num ^= this.TargetIncId.GetHashCode();
			}
			if (this.newData_ != null)
			{
				num ^= this.NewData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x00165BFD File Offset: 0x00163DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x00165C0A File Offset: 0x00163E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x00165C14 File Offset: 0x00163E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetIncId);
			}
			if (this.newData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NewData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x00165C6C File Offset: 0x00163E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetIncId);
			}
			if (this.newData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x00165CC4 File Offset: 0x00163EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FREvolveUpdateAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetIncId != 0)
			{
				this.TargetIncId = other.TargetIncId;
			}
			if (other.newData_ != null)
			{
				if (this.newData_ == null)
				{
					this.NewData = new FREvolveData();
				}
				this.NewData.MergeFrom(other.NewData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x00165D2C File Offset: 0x00163F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x00165D38 File Offset: 0x00163F38
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newData_ == null)
						{
							this.NewData = new FREvolveData();
						}
						input.ReadMessage(this.NewData);
					}
				}
				else
				{
					this.TargetIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004707 RID: 18183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004708 RID: 18184
		public const int TargetIncIdFieldNumber = 1;

		// Token: 0x04004709 RID: 18185
		private int targetIncId_;

		// Token: 0x0400470A RID: 18186
		public const int NewDataFieldNumber = 2;

		// Token: 0x0400470B RID: 18187
		private FREvolveData newData_;
	}
}
