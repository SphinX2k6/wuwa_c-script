using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CE RID: 2510
	[NetMessage(EMessageId.MaterialRequest)]
	public sealed class MaterialRequest : IMessage<MaterialRequest>, IMessage, IEquatable<MaterialRequest>, IDeepCloneable<MaterialRequest>, IBufferMessage
	{
		// Token: 0x0600DC2D RID: 56365 RVA: 0x002054F5 File Offset: 0x002036F5
		[NullableContext(1)]
		public static MaterialRequest Create()
		{
			return new MaterialRequest();
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0600DC2E RID: 56366 RVA: 0x002054FC File Offset: 0x002036FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x0600DC2F RID: 56367 RVA: 0x002054FF File Offset: 0x002036FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialRequest.Descriptor;
			}
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x00205506 File Offset: 0x00203706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest()
		{
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x00205510 File Offset: 0x00203710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest(MaterialRequest other) : this()
		{
			this.materialInfo_ = ((other.materialInfo_ != null) ? other.materialInfo_.Clone() : null);
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x0020556C File Offset: 0x0020376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest Clone()
		{
			return new MaterialRequest(this);
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x0600DC33 RID: 56371 RVA: 0x00205574 File Offset: 0x00203774
		// (set) Token: 0x0600DC34 RID: 56372 RVA: 0x0020557C File Offset: 0x0020377C
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

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x0600DC35 RID: 56373 RVA: 0x00205585 File Offset: 0x00203785
		// (set) Token: 0x0600DC36 RID: 56374 RVA: 0x0020558D File Offset: 0x0020378D
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

		// Token: 0x0600DC37 RID: 56375 RVA: 0x00205596 File Offset: 0x00203796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialRequest);
		}

		// Token: 0x0600DC38 RID: 56376 RVA: 0x002055A4 File Offset: 0x002037A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MaterialInfo, other.MaterialInfo) && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC39 RID: 56377 RVA: 0x002055F8 File Offset: 0x002037F8
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

		// Token: 0x0600DC3A RID: 56378 RVA: 0x0020564A File Offset: 0x0020384A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC3B RID: 56379 RVA: 0x00205657 File Offset: 0x00203857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC3C RID: 56380 RVA: 0x00205660 File Offset: 0x00203860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.materialInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MaterialInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC3D RID: 56381 RVA: 0x002056BC File Offset: 0x002038BC
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

		// Token: 0x0600DC3E RID: 56382 RVA: 0x00205714 File Offset: 0x00203914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialRequest other)
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

		// Token: 0x0600DC3F RID: 56383 RVA: 0x00205794 File Offset: 0x00203994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC40 RID: 56384 RVA: 0x002057A0 File Offset: 0x002039A0
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
				if (num != 58U)
				{
					if (num != 66U)
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

		// Token: 0x04005B45 RID: 23365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B46 RID: 23366
		public const int MaterialInfoFieldNumber = 8;

		// Token: 0x04005B47 RID: 23367
		private MaterialInfo materialInfo_;

		// Token: 0x04005B48 RID: 23368
		public const int CombatCommonFieldNumber = 7;

		// Token: 0x04005B49 RID: 23369
		private CombatCommon combatCommon_;
	}
}
