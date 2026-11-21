using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAB RID: 3243
	[NetMessage(EMessageId.PhantomBattleSlotInsteadRequest)]
	public sealed class PhantomBattleSlotInsteadRequest : IMessage<PhantomBattleSlotInsteadRequest>, IMessage, IEquatable<PhantomBattleSlotInsteadRequest>, IDeepCloneable<PhantomBattleSlotInsteadRequest>, IBufferMessage
	{
		// Token: 0x06011975 RID: 72053 RVA: 0x002940D5 File Offset: 0x002922D5
		[NullableContext(1)]
		public static PhantomBattleSlotInsteadRequest Create()
		{
			return new PhantomBattleSlotInsteadRequest();
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x06011976 RID: 72054 RVA: 0x002940DC File Offset: 0x002922DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x06011977 RID: 72055 RVA: 0x002940DF File Offset: 0x002922DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotInsteadRequest.Descriptor;
			}
		}

		// Token: 0x06011978 RID: 72056 RVA: 0x002940E6 File Offset: 0x002922E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadRequest()
		{
		}

		// Token: 0x06011979 RID: 72057 RVA: 0x002940EE File Offset: 0x002922EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadRequest(PhantomBattleSlotInsteadRequest other) : this()
		{
			this.startSlotIndex_ = other.startSlotIndex_;
			this.targetSlotIndex_ = other.targetSlotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601197A RID: 72058 RVA: 0x0029411F File Offset: 0x0029231F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadRequest Clone()
		{
			return new PhantomBattleSlotInsteadRequest(this);
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0601197B RID: 72059 RVA: 0x00294127 File Offset: 0x00292327
		// (set) Token: 0x0601197C RID: 72060 RVA: 0x0029412F File Offset: 0x0029232F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartSlotIndex
		{
			get
			{
				return this.startSlotIndex_;
			}
			set
			{
				this.startSlotIndex_ = value;
			}
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0601197D RID: 72061 RVA: 0x00294138 File Offset: 0x00292338
		// (set) Token: 0x0601197E RID: 72062 RVA: 0x00294140 File Offset: 0x00292340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetSlotIndex
		{
			get
			{
				return this.targetSlotIndex_;
			}
			set
			{
				this.targetSlotIndex_ = value;
			}
		}

		// Token: 0x0601197F RID: 72063 RVA: 0x00294149 File Offset: 0x00292349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotInsteadRequest);
		}

		// Token: 0x06011980 RID: 72064 RVA: 0x00294157 File Offset: 0x00292357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotInsteadRequest other)
		{
			return other != null && (other == this || (this.StartSlotIndex == other.StartSlotIndex && this.TargetSlotIndex == other.TargetSlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011981 RID: 72065 RVA: 0x00294198 File Offset: 0x00292398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartSlotIndex != 0)
			{
				num ^= this.StartSlotIndex.GetHashCode();
			}
			if (this.TargetSlotIndex != 0)
			{
				num ^= this.TargetSlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011982 RID: 72066 RVA: 0x002941F0 File Offset: 0x002923F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011983 RID: 72067 RVA: 0x002941FD File Offset: 0x002923FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011984 RID: 72068 RVA: 0x00294208 File Offset: 0x00292408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartSlotIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StartSlotIndex);
			}
			if (this.TargetSlotIndex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TargetSlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011985 RID: 72069 RVA: 0x00294260 File Offset: 0x00292460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StartSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartSlotIndex);
			}
			if (this.TargetSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetSlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011986 RID: 72070 RVA: 0x002942B8 File Offset: 0x002924B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSlotInsteadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StartSlotIndex != 0)
			{
				this.StartSlotIndex = other.StartSlotIndex;
			}
			if (other.TargetSlotIndex != 0)
			{
				this.TargetSlotIndex = other.TargetSlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011987 RID: 72071 RVA: 0x00294308 File Offset: 0x00292508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011988 RID: 72072 RVA: 0x00294314 File Offset: 0x00292514
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetSlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.StartSlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F3D RID: 28477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F3E RID: 28478
		public const int StartSlotIndexFieldNumber = 1;

		// Token: 0x04006F3F RID: 28479
		private int startSlotIndex_;

		// Token: 0x04006F40 RID: 28480
		public const int TargetSlotIndexFieldNumber = 15;

		// Token: 0x04006F41 RID: 28481
		private int targetSlotIndex_;
	}
}
