using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2D RID: 2605
	public sealed class MotorFightCtx : IMessage<MotorFightCtx>, IMessage, IEquatable<MotorFightCtx>, IDeepCloneable<MotorFightCtx>, IBufferMessage
	{
		// Token: 0x0600E3D7 RID: 58327 RVA: 0x00215767 File Offset: 0x00213967
		[NullableContext(1)]
		public static MotorFightCtx Create()
		{
			return new MotorFightCtx();
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x0021576E File Offset: 0x0021396E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x00215771 File Offset: 0x00213971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightCtx.Descriptor;
			}
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x00215778 File Offset: 0x00213978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx()
		{
		}

		// Token: 0x0600E3DB RID: 58331 RVA: 0x00215780 File Offset: 0x00213980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx(MotorFightCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.levelId_ = other.levelId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x002157BD File Offset: 0x002139BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCtx Clone()
		{
			return new MotorFightCtx(this);
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x002157C5 File Offset: 0x002139C5
		// (set) Token: 0x0600E3DE RID: 58334 RVA: 0x002157CD File Offset: 0x002139CD
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

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x002157D6 File Offset: 0x002139D6
		// (set) Token: 0x0600E3E0 RID: 58336 RVA: 0x002157DE File Offset: 0x002139DE
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

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x002157E7 File Offset: 0x002139E7
		// (set) Token: 0x0600E3E2 RID: 58338 RVA: 0x002157EF File Offset: 0x002139EF
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

		// Token: 0x0600E3E3 RID: 58339 RVA: 0x002157F8 File Offset: 0x002139F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightCtx);
		}

		// Token: 0x0600E3E4 RID: 58340 RVA: 0x00215808 File Offset: 0x00213A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.LevelId == other.LevelId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3E5 RID: 58341 RVA: 0x00215864 File Offset: 0x00213A64
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

		// Token: 0x0600E3E6 RID: 58342 RVA: 0x002158D5 File Offset: 0x00213AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3E7 RID: 58343 RVA: 0x002158E2 File Offset: 0x00213AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3E8 RID: 58344 RVA: 0x002158EC File Offset: 0x00213AEC
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

		// Token: 0x0600E3E9 RID: 58345 RVA: 0x00215960 File Offset: 0x00213B60
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

		// Token: 0x0600E3EA RID: 58346 RVA: 0x002159C4 File Offset: 0x00213BC4
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

		// Token: 0x0600E3EB RID: 58347 RVA: 0x00215A28 File Offset: 0x00213C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x00215A34 File Offset: 0x00213C34
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

		// Token: 0x04005DA7 RID: 23975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DA8 RID: 23976
		public const int ContinueFieldNumber = 1;

		// Token: 0x04005DA9 RID: 23977
		private bool continue_;

		// Token: 0x04005DAA RID: 23978
		public const int LevelIdFieldNumber = 2;

		// Token: 0x04005DAB RID: 23979
		private int levelId_;

		// Token: 0x04005DAC RID: 23980
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04005DAD RID: 23981
		private int roleId_;
	}
}
