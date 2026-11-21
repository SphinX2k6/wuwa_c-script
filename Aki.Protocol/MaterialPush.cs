using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BA RID: 2490
	[NetMessage(EMessageId.MaterialPush)]
	public sealed class MaterialPush : IMessage<MaterialPush>, IMessage, IEquatable<MaterialPush>, IDeepCloneable<MaterialPush>, IBufferMessage
	{
		// Token: 0x0600DAD7 RID: 56023 RVA: 0x00202AAA File Offset: 0x00200CAA
		[NullableContext(1)]
		public static MaterialPush Create()
		{
			return new MaterialPush();
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x00202AB1 File Offset: 0x00200CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x0600DAD9 RID: 56025 RVA: 0x00202AB4 File Offset: 0x00200CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialPush.Descriptor;
			}
		}

		// Token: 0x0600DADA RID: 56026 RVA: 0x00202ABB File Offset: 0x00200CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush()
		{
		}

		// Token: 0x0600DADB RID: 56027 RVA: 0x00202AC4 File Offset: 0x00200CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush(MaterialPush other) : this()
		{
			this.materialInfo_ = ((other.materialInfo_ != null) ? other.materialInfo_.Clone() : null);
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DADC RID: 56028 RVA: 0x00202B20 File Offset: 0x00200D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialPush Clone()
		{
			return new MaterialPush(this);
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0600DADD RID: 56029 RVA: 0x00202B28 File Offset: 0x00200D28
		// (set) Token: 0x0600DADE RID: 56030 RVA: 0x00202B30 File Offset: 0x00200D30
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

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0600DADF RID: 56031 RVA: 0x00202B39 File Offset: 0x00200D39
		// (set) Token: 0x0600DAE0 RID: 56032 RVA: 0x00202B41 File Offset: 0x00200D41
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

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x00202B4A File Offset: 0x00200D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialPush);
		}

		// Token: 0x0600DAE2 RID: 56034 RVA: 0x00202B58 File Offset: 0x00200D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialPush other)
		{
			return other != null && (other == this || (object.Equals(this.MaterialInfo, other.MaterialInfo) && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAE3 RID: 56035 RVA: 0x00202BAC File Offset: 0x00200DAC
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

		// Token: 0x0600DAE4 RID: 56036 RVA: 0x00202BFE File Offset: 0x00200DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DAE5 RID: 56037 RVA: 0x00202C0B File Offset: 0x00200E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x00202C14 File Offset: 0x00200E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.materialInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MaterialInfo);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x00202C70 File Offset: 0x00200E70
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

		// Token: 0x0600DAE8 RID: 56040 RVA: 0x00202CC8 File Offset: 0x00200EC8
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

		// Token: 0x0600DAE9 RID: 56041 RVA: 0x00202D48 File Offset: 0x00200F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAEA RID: 56042 RVA: 0x00202D54 File Offset: 0x00200F54
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
				if (num != 18U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					if (this.materialInfo_ == null)
					{
						this.MaterialInfo = new MaterialInfo();
					}
					input.ReadMessage(this.MaterialInfo);
				}
			}
		}

		// Token: 0x04005B3F RID: 23359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B40 RID: 23360
		public const int MaterialInfoFieldNumber = 2;

		// Token: 0x04005B41 RID: 23361
		private MaterialInfo materialInfo_;

		// Token: 0x04005B42 RID: 23362
		public const int CombatCommonFieldNumber = 3;

		// Token: 0x04005B43 RID: 23363
		private CombatCommon combatCommon_;
	}
}
