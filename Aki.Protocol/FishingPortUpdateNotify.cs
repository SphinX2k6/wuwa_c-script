using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055C RID: 1372
	[NetMessage(EMessageId.FishingPortUpdateNotify)]
	public sealed class FishingPortUpdateNotify : IMessage<FishingPortUpdateNotify>, IMessage, IEquatable<FishingPortUpdateNotify>, IDeepCloneable<FishingPortUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008045 RID: 32837 RVA: 0x001367B5 File Offset: 0x001349B5
		[NullableContext(1)]
		public static FishingPortUpdateNotify Create()
		{
			return new FishingPortUpdateNotify();
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06008046 RID: 32838 RVA: 0x001367BC File Offset: 0x001349BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06008047 RID: 32839 RVA: 0x001367BF File Offset: 0x001349BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPortUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x001367C6 File Offset: 0x001349C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUpdateNotify()
		{
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x001367CE File Offset: 0x001349CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUpdateNotify(FishingPortUpdateNotify other) : this()
		{
			this.isInPort_ = other.isInPort_;
			this.portId_ = other.portId_;
			this.lastPortId_ = other.lastPortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x0013680B File Offset: 0x00134A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUpdateNotify Clone()
		{
			return new FishingPortUpdateNotify(this);
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x0600804B RID: 32843 RVA: 0x00136813 File Offset: 0x00134A13
		// (set) Token: 0x0600804C RID: 32844 RVA: 0x0013681B File Offset: 0x00134A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInPort
		{
			get
			{
				return this.isInPort_;
			}
			set
			{
				this.isInPort_ = value;
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x0600804D RID: 32845 RVA: 0x00136824 File Offset: 0x00134A24
		// (set) Token: 0x0600804E RID: 32846 RVA: 0x0013682C File Offset: 0x00134A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PortId
		{
			get
			{
				return this.portId_;
			}
			set
			{
				this.portId_ = value;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x0600804F RID: 32847 RVA: 0x00136835 File Offset: 0x00134A35
		// (set) Token: 0x06008050 RID: 32848 RVA: 0x0013683D File Offset: 0x00134A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastPortId
		{
			get
			{
				return this.lastPortId_;
			}
			set
			{
				this.lastPortId_ = value;
			}
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x00136846 File Offset: 0x00134A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPortUpdateNotify);
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x00136854 File Offset: 0x00134A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPortUpdateNotify other)
		{
			return other != null && (other == this || (this.IsInPort == other.IsInPort && this.PortId == other.PortId && this.LastPortId == other.LastPortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x001368B0 File Offset: 0x00134AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsInPort)
			{
				num ^= this.IsInPort.GetHashCode();
			}
			if (this.PortId != 0)
			{
				num ^= this.PortId.GetHashCode();
			}
			if (this.LastPortId != 0)
			{
				num ^= this.LastPortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x00136921 File Offset: 0x00134B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x0013692E File Offset: 0x00134B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x00136938 File Offset: 0x00134B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PortId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PortId);
			}
			if (this.IsInPort)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsInPort);
			}
			if (this.LastPortId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LastPortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x001369B0 File Offset: 0x00134BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsInPort)
			{
				num += 2;
			}
			if (this.PortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PortId);
			}
			if (this.LastPortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastPortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00136A14 File Offset: 0x00134C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingPortUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsInPort)
			{
				this.IsInPort = other.IsInPort;
			}
			if (other.PortId != 0)
			{
				this.PortId = other.PortId;
			}
			if (other.LastPortId != 0)
			{
				this.LastPortId = other.LastPortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x00136A78 File Offset: 0x00134C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00136A84 File Offset: 0x00134C84
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
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LastPortId = input.ReadInt32();
						}
					}
					else
					{
						this.IsInPort = input.ReadBool();
					}
				}
				else
				{
					this.PortId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004109 RID: 16649
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400410A RID: 16650
		public const int IsInPortFieldNumber = 8;

		// Token: 0x0400410B RID: 16651
		private bool isInPort_;

		// Token: 0x0400410C RID: 16652
		public const int PortIdFieldNumber = 4;

		// Token: 0x0400410D RID: 16653
		private int portId_;

		// Token: 0x0400410E RID: 16654
		public const int LastPortIdFieldNumber = 10;

		// Token: 0x0400410F RID: 16655
		private int lastPortId_;
	}
}
