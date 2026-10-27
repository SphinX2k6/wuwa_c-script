using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBB RID: 3259
	[NetMessage(EMessageId.PhantomBattleSlotInsteadRequest)]
	public sealed class PhantomBattleSlotInsteadRequest : IMessage<PhantomBattleSlotInsteadRequest>, IMessage, IEquatable<PhantomBattleSlotInsteadRequest>, IDeepCloneable<PhantomBattleSlotInsteadRequest>, IBufferMessage
	{
		// Token: 0x06011A75 RID: 72309 RVA: 0x00295E34 File Offset: 0x00294034
		[NullableContext(1)]
		public static PhantomBattleSlotInsteadRequest Create()
		{
			return new PhantomBattleSlotInsteadRequest();
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x06011A76 RID: 72310 RVA: 0x00295E3B File Offset: 0x0029403B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x06011A77 RID: 72311 RVA: 0x00295E3E File Offset: 0x0029403E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotInsteadRequest.Descriptor;
			}
		}

		// Token: 0x06011A78 RID: 72312 RVA: 0x00295E45 File Offset: 0x00294045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadRequest()
		{
		}

		// Token: 0x06011A79 RID: 72313 RVA: 0x00295E4D File Offset: 0x0029404D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadRequest(PhantomBattleSlotInsteadRequest other) : this()
		{
			this.startSlotIndex_ = other.startSlotIndex_;
			this.targetSlotIndex_ = other.targetSlotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A7A RID: 72314 RVA: 0x00295E7E File Offset: 0x0029407E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadRequest Clone()
		{
			return new PhantomBattleSlotInsteadRequest(this);
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x06011A7B RID: 72315 RVA: 0x00295E86 File Offset: 0x00294086
		// (set) Token: 0x06011A7C RID: 72316 RVA: 0x00295E8E File Offset: 0x0029408E
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

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x06011A7D RID: 72317 RVA: 0x00295E97 File Offset: 0x00294097
		// (set) Token: 0x06011A7E RID: 72318 RVA: 0x00295E9F File Offset: 0x0029409F
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

		// Token: 0x06011A7F RID: 72319 RVA: 0x00295EA8 File Offset: 0x002940A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotInsteadRequest);
		}

		// Token: 0x06011A80 RID: 72320 RVA: 0x00295EB6 File Offset: 0x002940B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotInsteadRequest other)
		{
			return other != null && (other == this || (this.StartSlotIndex == other.StartSlotIndex && this.TargetSlotIndex == other.TargetSlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A81 RID: 72321 RVA: 0x00295EF4 File Offset: 0x002940F4
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

		// Token: 0x06011A82 RID: 72322 RVA: 0x00295F4C File Offset: 0x0029414C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A83 RID: 72323 RVA: 0x00295F59 File Offset: 0x00294159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A84 RID: 72324 RVA: 0x00295F64 File Offset: 0x00294164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetSlotIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TargetSlotIndex);
			}
			if (this.StartSlotIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.StartSlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A85 RID: 72325 RVA: 0x00295FC0 File Offset: 0x002941C0
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

		// Token: 0x06011A86 RID: 72326 RVA: 0x00296018 File Offset: 0x00294218
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

		// Token: 0x06011A87 RID: 72327 RVA: 0x00296068 File Offset: 0x00294268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A88 RID: 72328 RVA: 0x00296074 File Offset: 0x00294274
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StartSlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.TargetSlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F29 RID: 28457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F2A RID: 28458
		public const int StartSlotIndexFieldNumber = 12;

		// Token: 0x04006F2B RID: 28459
		private int startSlotIndex_;

		// Token: 0x04006F2C RID: 28460
		public const int TargetSlotIndexFieldNumber = 11;

		// Token: 0x04006F2D RID: 28461
		private int targetSlotIndex_;
	}
}
