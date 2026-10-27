using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CB RID: 2507
	[NetMessage(EMessageId.MaterialPush)]
	public sealed class MaterialPush : IMessage<MaterialPush>, IMessage, IEquatable<MaterialPush>, IDeepCloneable<MaterialPush>, IBufferMessage
	{
		// Token: 0x0600DBF1 RID: 56305 RVA: 0x00204CA2 File Offset: 0x00202EA2
		[NullableContext(1)]
		public static MaterialPush Create()
		{
			return new MaterialPush();
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x0600DBF2 RID: 56306 RVA: 0x00204CA9 File Offset: 0x00202EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x0600DBF3 RID: 56307 RVA: 0x00204CAC File Offset: 0x00202EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialPush.Descriptor;
			}
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x00204CB3 File Offset: 0x00202EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush()
		{
		}

		// Token: 0x0600DBF5 RID: 56309 RVA: 0x00204CBC File Offset: 0x00202EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush(MaterialPush other) : this()
		{
			this.materialInfo_ = ((other.materialInfo_ != null) ? other.materialInfo_.Clone() : null);
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBF6 RID: 56310 RVA: 0x00204D18 File Offset: 0x00202F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush Clone()
		{
			return new MaterialPush(this);
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600DBF7 RID: 56311 RVA: 0x00204D20 File Offset: 0x00202F20
		// (set) Token: 0x0600DBF8 RID: 56312 RVA: 0x00204D28 File Offset: 0x00202F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo MaterialInfo
		{
			get
			{
				return this.materialInfo_;
			}
			set
			{
				this.materialInfo_ = value;
			}
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600DBF9 RID: 56313 RVA: 0x00204D31 File Offset: 0x00202F31
		// (set) Token: 0x0600DBFA RID: 56314 RVA: 0x00204D39 File Offset: 0x00202F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x0600DBFB RID: 56315 RVA: 0x00204D42 File Offset: 0x00202F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialPush);
		}

		// Token: 0x0600DBFC RID: 56316 RVA: 0x00204D50 File Offset: 0x00202F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialPush other)
		{
			return other != null && (other == this || (object.Equals(this.MaterialInfo, other.MaterialInfo) && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBFD RID: 56317 RVA: 0x00204DA4 File Offset: 0x00202FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.materialInfo_ != null)
			{
				num ^= this.MaterialInfo.GetHashCode();
			}
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBFE RID: 56318 RVA: 0x00204DF6 File Offset: 0x00202FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBFF RID: 56319 RVA: 0x00204E03 File Offset: 0x00203003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC00 RID: 56320 RVA: 0x00204E0C File Offset: 0x0020300C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.materialInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MaterialInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC01 RID: 56321 RVA: 0x00204E68 File Offset: 0x00203068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.materialInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MaterialInfo);
			}
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC02 RID: 56322 RVA: 0x00204EC0 File Offset: 0x002030C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.materialInfo_ != null)
			{
				if (this.materialInfo_ == null)
				{
					this.MaterialInfo = new MaterialInfo();
				}
				this.MaterialInfo.MergeFrom(other.MaterialInfo);
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC03 RID: 56323 RVA: 0x00204F40 File Offset: 0x00203140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x00204F4C File Offset: 0x0020314C
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
				if (num != 50U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.materialInfo_ == null)
						{
							this.MaterialInfo = new MaterialInfo();
						}
						input.ReadMessage(this.MaterialInfo);
					}
				}
				else
				{
					if (this.combatCommon_ == null)
					{
						this.CombatCommon = new CombatCommon();
					}
					input.ReadMessage(this.CombatCommon);
				}
			}
		}

		// Token: 0x04005B36 RID: 23350
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B37 RID: 23351
		public const int MaterialInfoFieldNumber = 11;

		// Token: 0x04005B38 RID: 23352
		private MaterialInfo materialInfo_;

		// Token: 0x04005B39 RID: 23353
		public const int CombatCommonFieldNumber = 6;

		// Token: 0x04005B3A RID: 23354
		private CombatCommon combatCommon_;
	}
}
