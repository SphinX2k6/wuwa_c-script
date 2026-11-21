using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087C RID: 2172
	public sealed class KurotatoCtx : IMessage<KurotatoCtx>, IMessage, IEquatable<KurotatoCtx>, IDeepCloneable<KurotatoCtx>, IBufferMessage
	{
		// Token: 0x0600C19D RID: 49565 RVA: 0x001CC2B8 File Offset: 0x001CA4B8
		[NullableContext(1)]
		public static KurotatoCtx Create()
		{
			return new KurotatoCtx();
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x0600C19E RID: 49566 RVA: 0x001CC2BF File Offset: 0x001CA4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x0600C19F RID: 49567 RVA: 0x001CC2C2 File Offset: 0x001CA4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoCtx.Descriptor;
			}
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x001CC2C9 File Offset: 0x001CA4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx()
		{
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x001CC2D1 File Offset: 0x001CA4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx(KurotatoCtx other) : this()
		{
			this.continue_ = other.continue_;
			this.levelId_ = other.levelId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1A2 RID: 49570 RVA: 0x001CC30E File Offset: 0x001CA50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCtx Clone()
		{
			return new KurotatoCtx(this);
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600C1A3 RID: 49571 RVA: 0x001CC316 File Offset: 0x001CA516
		// (set) Token: 0x0600C1A4 RID: 49572 RVA: 0x001CC31E File Offset: 0x001CA51E
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

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600C1A5 RID: 49573 RVA: 0x001CC327 File Offset: 0x001CA527
		// (set) Token: 0x0600C1A6 RID: 49574 RVA: 0x001CC32F File Offset: 0x001CA52F
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

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x001CC338 File Offset: 0x001CA538
		// (set) Token: 0x0600C1A8 RID: 49576 RVA: 0x001CC340 File Offset: 0x001CA540
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

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x001CC349 File Offset: 0x001CA549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoCtx);
		}

		// Token: 0x0600C1AA RID: 49578 RVA: 0x001CC358 File Offset: 0x001CA558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoCtx other)
		{
			return other != null && (other == this || (this.Continue == other.Continue && this.LevelId == other.LevelId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1AB RID: 49579 RVA: 0x001CC3B4 File Offset: 0x001CA5B4
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

		// Token: 0x0600C1AC RID: 49580 RVA: 0x001CC425 File Offset: 0x001CA625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1AD RID: 49581 RVA: 0x001CC432 File Offset: 0x001CA632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1AE RID: 49582 RVA: 0x001CC43C File Offset: 0x001CA63C
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

		// Token: 0x0600C1AF RID: 49583 RVA: 0x001CC4B0 File Offset: 0x001CA6B0
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

		// Token: 0x0600C1B0 RID: 49584 RVA: 0x001CC514 File Offset: 0x001CA714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoCtx other)
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

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x001CC578 File Offset: 0x001CA778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1B2 RID: 49586 RVA: 0x001CC584 File Offset: 0x001CA784
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

		// Token: 0x04005451 RID: 21585
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005452 RID: 21586
		public const int ContinueFieldNumber = 1;

		// Token: 0x04005453 RID: 21587
		private bool continue_;

		// Token: 0x04005454 RID: 21588
		public const int LevelIdFieldNumber = 2;

		// Token: 0x04005455 RID: 21589
		private int levelId_;

		// Token: 0x04005456 RID: 21590
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04005457 RID: 21591
		private int roleId_;
	}
}
