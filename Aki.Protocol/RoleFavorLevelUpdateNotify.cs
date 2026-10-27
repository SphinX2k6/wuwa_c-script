using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001072 RID: 4210
	[NetMessage(EMessageId.RoleFavorLevelUpdateNotify)]
	public sealed class RoleFavorLevelUpdateNotify : IMessage<RoleFavorLevelUpdateNotify>, IMessage, IEquatable<RoleFavorLevelUpdateNotify>, IDeepCloneable<RoleFavorLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x060167F3 RID: 92147 RVA: 0x003454A7 File Offset: 0x003436A7
		[NullableContext(1)]
		public static RoleFavorLevelUpdateNotify Create()
		{
			return new RoleFavorLevelUpdateNotify();
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x060167F4 RID: 92148 RVA: 0x003454AE File Offset: 0x003436AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x060167F5 RID: 92149 RVA: 0x003454B1 File Offset: 0x003436B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060167F6 RID: 92150 RVA: 0x003454B8 File Offset: 0x003436B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorLevelUpdateNotify()
		{
		}

		// Token: 0x060167F7 RID: 92151 RVA: 0x003454C0 File Offset: 0x003436C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorLevelUpdateNotify(RoleFavorLevelUpdateNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167F8 RID: 92152 RVA: 0x003454FD File Offset: 0x003436FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorLevelUpdateNotify Clone()
		{
			return new RoleFavorLevelUpdateNotify(this);
		}

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x060167F9 RID: 92153 RVA: 0x00345505 File Offset: 0x00343705
		// (set) Token: 0x060167FA RID: 92154 RVA: 0x0034550D File Offset: 0x0034370D
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

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x060167FB RID: 92155 RVA: 0x00345516 File Offset: 0x00343716
		// (set) Token: 0x060167FC RID: 92156 RVA: 0x0034551E File Offset: 0x0034371E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x060167FD RID: 92157 RVA: 0x00345527 File Offset: 0x00343727
		// (set) Token: 0x060167FE RID: 92158 RVA: 0x0034552F File Offset: 0x0034372F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x060167FF RID: 92159 RVA: 0x00345538 File Offset: 0x00343738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorLevelUpdateNotify);
		}

		// Token: 0x06016800 RID: 92160 RVA: 0x00345548 File Offset: 0x00343748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016801 RID: 92161 RVA: 0x003455A4 File Offset: 0x003437A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016802 RID: 92162 RVA: 0x00345615 File Offset: 0x00343815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016803 RID: 92163 RVA: 0x00345622 File Offset: 0x00343822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016804 RID: 92164 RVA: 0x0034562C File Offset: 0x0034382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Exp);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016805 RID: 92165 RVA: 0x003456A4 File Offset: 0x003438A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016806 RID: 92166 RVA: 0x00345714 File Offset: 0x00343914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016807 RID: 92167 RVA: 0x00345778 File Offset: 0x00343978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016808 RID: 92168 RVA: 0x00345784 File Offset: 0x00343984
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadInt32();
						}
					}
					else
					{
						this.Exp = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400868D RID: 34445
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400868E RID: 34446
		public const int RoleIdFieldNumber = 2;

		// Token: 0x0400868F RID: 34447
		private int roleId_;

		// Token: 0x04008690 RID: 34448
		public const int LevelFieldNumber = 9;

		// Token: 0x04008691 RID: 34449
		private int level_;

		// Token: 0x04008692 RID: 34450
		public const int ExpFieldNumber = 6;

		// Token: 0x04008693 RID: 34451
		private int exp_;
	}
}
