using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BD RID: 2493
	[NetMessage(EMessageId.MaterialRequest)]
	public sealed class MaterialRequest : IMessage<MaterialRequest>, IMessage, IEquatable<MaterialRequest>, IDeepCloneable<MaterialRequest>, IBufferMessage
	{
		// Token: 0x0600DB13 RID: 56083 RVA: 0x002032FD File Offset: 0x002014FD
		[NullableContext(1)]
		public static MaterialRequest Create()
		{
			return new MaterialRequest();
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x00203304 File Offset: 0x00201504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x0600DB15 RID: 56085 RVA: 0x00203307 File Offset: 0x00201507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialRequest.Descriptor;
			}
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x0020330E File Offset: 0x0020150E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest()
		{
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00203318 File Offset: 0x00201518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest(MaterialRequest other) : this()
		{
			this.materialInfo_ = ((other.materialInfo_ != null) ? other.materialInfo_.Clone() : null);
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x00203374 File Offset: 0x00201574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialRequest Clone()
		{
			return new MaterialRequest(this);
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x0600DB19 RID: 56089 RVA: 0x0020337C File Offset: 0x0020157C
		// (set) Token: 0x0600DB1A RID: 56090 RVA: 0x00203384 File Offset: 0x00201584
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

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x0600DB1B RID: 56091 RVA: 0x0020338D File Offset: 0x0020158D
		// (set) Token: 0x0600DB1C RID: 56092 RVA: 0x00203395 File Offset: 0x00201595
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

		// Token: 0x0600DB1D RID: 56093 RVA: 0x0020339E File Offset: 0x0020159E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialRequest);
		}

		// Token: 0x0600DB1E RID: 56094 RVA: 0x002033AC File Offset: 0x002015AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MaterialInfo, other.MaterialInfo) && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00203400 File Offset: 0x00201600
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

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00203452 File Offset: 0x00201652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x0020345F File Offset: 0x0020165F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x00203468 File Offset: 0x00201668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.materialInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MaterialInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x002034C4 File Offset: 0x002016C4
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

		// Token: 0x0600DB24 RID: 56100 RVA: 0x0020351C File Offset: 0x0020171C
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

		// Token: 0x0600DB25 RID: 56101 RVA: 0x0020359C File Offset: 0x0020179C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x002035A8 File Offset: 0x002017A8
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
				if (num != 26U)
				{
					if (num != 50U)
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

		// Token: 0x04005B4E RID: 23374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B4F RID: 23375
		public const int MaterialInfoFieldNumber = 6;

		// Token: 0x04005B50 RID: 23376
		private MaterialInfo materialInfo_;

		// Token: 0x04005B51 RID: 23377
		public const int CombatCommonFieldNumber = 3;

		// Token: 0x04005B52 RID: 23378
		private CombatCommon combatCommon_;
	}
}
