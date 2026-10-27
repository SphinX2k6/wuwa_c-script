using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060F RID: 1551
	[NetMessage(EMessageId.FlySkinUnLoadRequest)]
	public sealed class FlySkinUnLoadRequest : IMessage<FlySkinUnLoadRequest>, IMessage, IEquatable<FlySkinUnLoadRequest>, IDeepCloneable<FlySkinUnLoadRequest>, IBufferMessage
	{
		// Token: 0x06008F56 RID: 36694 RVA: 0x0015B453 File Offset: 0x00159653
		[NullableContext(1)]
		public static FlySkinUnLoadRequest Create()
		{
			return new FlySkinUnLoadRequest();
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06008F57 RID: 36695 RVA: 0x0015B45A File Offset: 0x0015965A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x0015B45D File Offset: 0x0015965D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinUnLoadRequest.Descriptor;
			}
		}

		// Token: 0x06008F59 RID: 36697 RVA: 0x0015B464 File Offset: 0x00159664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadRequest()
		{
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x0015B46C File Offset: 0x0015966C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadRequest(FlySkinUnLoadRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x0015B49D File Offset: 0x0015969D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadRequest Clone()
		{
			return new FlySkinUnLoadRequest(this);
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06008F5C RID: 36700 RVA: 0x0015B4A5 File Offset: 0x001596A5
		// (set) Token: 0x06008F5D RID: 36701 RVA: 0x0015B4AD File Offset: 0x001596AD
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

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06008F5E RID: 36702 RVA: 0x0015B4B6 File Offset: 0x001596B6
		// (set) Token: 0x06008F5F RID: 36703 RVA: 0x0015B4BE File Offset: 0x001596BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0015B4C7 File Offset: 0x001596C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinUnLoadRequest);
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x0015B4D5 File Offset: 0x001596D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinUnLoadRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x0015B514 File Offset: 0x00159714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0015B56C File Offset: 0x0015976C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0015B579 File Offset: 0x00159779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x0015B584 File Offset: 0x00159784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x0015B5E0 File Offset: 0x001597E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F67 RID: 36711 RVA: 0x0015B638 File Offset: 0x00159838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinUnLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F68 RID: 36712 RVA: 0x0015B688 File Offset: 0x00159888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F69 RID: 36713 RVA: 0x0015B694 File Offset: 0x00159894
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400459F RID: 17823
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045A0 RID: 17824
		public const int RoleIdFieldNumber = 4;

		// Token: 0x040045A1 RID: 17825
		private int roleId_;

		// Token: 0x040045A2 RID: 17826
		public const int SkinIdFieldNumber = 7;

		// Token: 0x040045A3 RID: 17827
		private int skinId_;
	}
}
