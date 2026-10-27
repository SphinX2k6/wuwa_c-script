using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CA RID: 2506
	[NetMessage(EMessageId.MaterialNotify)]
	public sealed class MaterialNotify : IMessage<MaterialNotify>, IMessage, IEquatable<MaterialNotify>, IDeepCloneable<MaterialNotify>, IBufferMessage
	{
		// Token: 0x0600DBDD RID: 56285 RVA: 0x0020497A File Offset: 0x00202B7A
		[NullableContext(1)]
		public static MaterialNotify Create()
		{
			return new MaterialNotify();
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600DBDE RID: 56286 RVA: 0x00204981 File Offset: 0x00202B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0600DBDF RID: 56287 RVA: 0x00204984 File Offset: 0x00202B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialNotify.Descriptor;
			}
		}

		// Token: 0x0600DBE0 RID: 56288 RVA: 0x0020498B File Offset: 0x00202B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify()
		{
		}

		// Token: 0x0600DBE1 RID: 56289 RVA: 0x00204994 File Offset: 0x00202B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify(MaterialNotify other) : this()
		{
			this.materialInfo_ = ((other.materialInfo_ != null) ? other.materialInfo_.Clone() : null);
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBE2 RID: 56290 RVA: 0x002049F0 File Offset: 0x00202BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialNotify Clone()
		{
			return new MaterialNotify(this);
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0600DBE3 RID: 56291 RVA: 0x002049F8 File Offset: 0x00202BF8
		// (set) Token: 0x0600DBE4 RID: 56292 RVA: 0x00204A00 File Offset: 0x00202C00
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

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0600DBE5 RID: 56293 RVA: 0x00204A09 File Offset: 0x00202C09
		// (set) Token: 0x0600DBE6 RID: 56294 RVA: 0x00204A11 File Offset: 0x00202C11
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

		// Token: 0x0600DBE7 RID: 56295 RVA: 0x00204A1A File Offset: 0x00202C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialNotify);
		}

		// Token: 0x0600DBE8 RID: 56296 RVA: 0x00204A28 File Offset: 0x00202C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MaterialInfo, other.MaterialInfo) && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBE9 RID: 56297 RVA: 0x00204A7C File Offset: 0x00202C7C
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

		// Token: 0x0600DBEA RID: 56298 RVA: 0x00204ACE File Offset: 0x00202CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBEB RID: 56299 RVA: 0x00204ADB File Offset: 0x00202CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBEC RID: 56300 RVA: 0x00204AE4 File Offset: 0x00202CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.materialInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MaterialInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBED RID: 56301 RVA: 0x00204B40 File Offset: 0x00202D40
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

		// Token: 0x0600DBEE RID: 56302 RVA: 0x00204B98 File Offset: 0x00202D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialNotify other)
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

		// Token: 0x0600DBEF RID: 56303 RVA: 0x00204C18 File Offset: 0x00202E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBF0 RID: 56304 RVA: 0x00204C24 File Offset: 0x00202E24
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
				if (num != 82U)
				{
					if (num != 98U)
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

		// Token: 0x04005B31 RID: 23345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B32 RID: 23346
		public const int MaterialInfoFieldNumber = 12;

		// Token: 0x04005B33 RID: 23347
		private MaterialInfo materialInfo_;

		// Token: 0x04005B34 RID: 23348
		public const int CombatCommonFieldNumber = 10;

		// Token: 0x04005B35 RID: 23349
		private CombatCommon combatCommon_;
	}
}
