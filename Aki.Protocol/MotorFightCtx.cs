using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3E RID: 2622
	public sealed class MotorFightCtx : IMessage<MotorFightCtx>, IMessage, IEquatable<MotorFightCtx>, IDeepCloneable<MotorFightCtx>, IBufferMessage
	{
		// Token: 0x0600E4F1 RID: 58609 RVA: 0x00217957 File Offset: 0x00215B57
		[NullableContext(1)]
		public static MotorFightCtx Create()
		{
			return new MotorFightCtx();
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600E4F2 RID: 58610 RVA: 0x0021795E File Offset: 0x00215B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x00217961 File Offset: 0x00215B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightCtx.Descriptor;
			}
		}

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x00217968 File Offset: 0x00215B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx()
		{
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00217970 File Offset: 0x00215B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx(MotorFightCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.levelId_ = other.levelId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x002179AD File Offset: 0x00215BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx Clone()
		{
			return new MotorFightCtx(this);
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x002179B5 File Offset: 0x00215BB5
		// (set) Token: 0x0600E4F8 RID: 58616 RVA: 0x002179BD File Offset: 0x00215BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Continue
		{
			get
			{
				return this.continue_;
			}
			set
			{
				this.continue_ = value;
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x002179C6 File Offset: 0x00215BC6
		// (set) Token: 0x0600E4FA RID: 58618 RVA: 0x002179CE File Offset: 0x00215BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x002179D7 File Offset: 0x00215BD7
		// (set) Token: 0x0600E4FC RID: 58620 RVA: 0x002179DF File Offset: 0x00215BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x002179E8 File Offset: 0x00215BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightCtx);
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x002179F8 File Offset: 0x00215BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.LevelId == other.LevelId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4FF RID: 58623 RVA: 0x00217A54 File Offset: 0x00215C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Continue)
			{
				num ^= this.Continue.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E500 RID: 58624 RVA: 0x00217AC5 File Offset: 0x00215CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x00217AD2 File Offset: 0x00215CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00217ADC File Offset: 0x00215CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Continue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Continue);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E503 RID: 58627 RVA: 0x00217B50 File Offset: 0x00215D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Continue)
			{
				num += 2;
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E504 RID: 58628 RVA: 0x00217BB4 File Offset: 0x00215DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Continue)
			{
				this.Continue = other.Continue;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E505 RID: 58629 RVA: 0x00217C18 File Offset: 0x00215E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E506 RID: 58630 RVA: 0x00217C24 File Offset: 0x00215E24
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.Continue = input.ReadBool();
				}
			}
		}

		// Token: 0x04005D9E RID: 23966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D9F RID: 23967
		public const int ContinueFieldNumber = 1;

		// Token: 0x04005DA0 RID: 23968
		private bool continue_;

		// Token: 0x04005DA1 RID: 23969
		public const int LevelIdFieldNumber = 2;

		// Token: 0x04005DA2 RID: 23970
		private int levelId_;

		// Token: 0x04005DA3 RID: 23971
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04005DA4 RID: 23972
		private int roleId_;
	}
}
