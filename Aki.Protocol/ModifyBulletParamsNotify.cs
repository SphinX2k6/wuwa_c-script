using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D6 RID: 2518
	[NetMessage(EMessageId.ModifyBulletParamsNotify)]
	public sealed class ModifyBulletParamsNotify : IMessage<ModifyBulletParamsNotify>, IMessage, IEquatable<ModifyBulletParamsNotify>, IDeepCloneable<ModifyBulletParamsNotify>, IBufferMessage
	{
		// Token: 0x0600DD07 RID: 56583 RVA: 0x002073C0 File Offset: 0x002055C0
		[NullableContext(1)]
		public static ModifyBulletParamsNotify Create()
		{
			return new ModifyBulletParamsNotify();
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0600DD08 RID: 56584 RVA: 0x002073C7 File Offset: 0x002055C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0600DD09 RID: 56585 RVA: 0x002073CA File Offset: 0x002055CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBulletParamsNotify.Descriptor;
			}
		}

		// Token: 0x0600DD0A RID: 56586 RVA: 0x002073D1 File Offset: 0x002055D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify()
		{
		}

		// Token: 0x0600DD0B RID: 56587 RVA: 0x002073D9 File Offset: 0x002055D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify(ModifyBulletParamsNotify other) : this()
		{
			this.modifyBulletParams_ = ((other.modifyBulletParams_ != null) ? other.modifyBulletParams_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD0C RID: 56588 RVA: 0x0020740E File Offset: 0x0020560E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParamsNotify Clone()
		{
			return new ModifyBulletParamsNotify(this);
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x00207416 File Offset: 0x00205616
		// (set) Token: 0x0600DD0E RID: 56590 RVA: 0x0020741E File Offset: 0x0020561E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyBulletParams ModifyBulletParams
		{
			get
			{
				return this.modifyBulletParams_;
			}
			set
			{
				this.modifyBulletParams_ = value;
			}
		}

		// Token: 0x0600DD0F RID: 56591 RVA: 0x00207427 File Offset: 0x00205627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBulletParamsNotify);
		}

		// Token: 0x0600DD10 RID: 56592 RVA: 0x00207435 File Offset: 0x00205635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyBulletParamsNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ModifyBulletParams, other.ModifyBulletParams) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD11 RID: 56593 RVA: 0x00207468 File Offset: 0x00205668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.modifyBulletParams_ != null)
			{
				num ^= this.ModifyBulletParams.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD12 RID: 56594 RVA: 0x002074A4 File Offset: 0x002056A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD13 RID: 56595 RVA: 0x002074B1 File Offset: 0x002056B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD14 RID: 56596 RVA: 0x002074BA File Offset: 0x002056BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifyBulletParams_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD15 RID: 56597 RVA: 0x002074EC File Offset: 0x002056EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.modifyBulletParams_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifyBulletParams);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD16 RID: 56598 RVA: 0x0020752C File Offset: 0x0020572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyBulletParamsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.modifyBulletParams_ != null)
			{
				if (this.modifyBulletParams_ == null)
				{
					this.ModifyBulletParams = new ModifyBulletParams();
				}
				this.ModifyBulletParams.MergeFrom(other.ModifyBulletParams);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD17 RID: 56599 RVA: 0x00207580 File Offset: 0x00205780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD18 RID: 56600 RVA: 0x0020758C File Offset: 0x0020578C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.modifyBulletParams_ == null)
					{
						this.ModifyBulletParams = new ModifyBulletParams();
					}
					input.ReadMessage(this.ModifyBulletParams);
				}
			}
		}

		// Token: 0x04005BD0 RID: 23504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD1 RID: 23505
		public const int ModifyBulletParamsFieldNumber = 12;

		// Token: 0x04005BD2 RID: 23506
		private ModifyBulletParams modifyBulletParams_;
	}
}
