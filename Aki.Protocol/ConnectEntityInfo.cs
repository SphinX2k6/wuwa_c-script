using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D5 RID: 725
	public sealed class ConnectEntityInfo : IMessage<ConnectEntityInfo>, IMessage, IEquatable<ConnectEntityInfo>, IDeepCloneable<ConnectEntityInfo>, IBufferMessage
	{
		// Token: 0x06004A31 RID: 18993 RVA: 0x000B54E2 File Offset: 0x000B36E2
		[NullableContext(1)]
		public static ConnectEntityInfo Create()
		{
			return new ConnectEntityInfo();
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06004A32 RID: 18994 RVA: 0x000B54E9 File Offset: 0x000B36E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConnectEntityInfo> Parser
		{
			get
			{
				return ConnectEntityInfo._parser;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x000B54F0 File Offset: 0x000B36F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06004A34 RID: 18996 RVA: 0x000B54F3 File Offset: 0x000B36F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectEntityInfo.Descriptor;
			}
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x000B54FA File Offset: 0x000B36FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo()
		{
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x000B5510 File Offset: 0x000B3710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo(ConnectEntityInfo other) : this()
		{
			this.srcEntityId_ = other.srcEntityId_;
			this.targetEntityInfos_ = other.targetEntityInfos_.Clone();
			this.isConnect_ = other.isConnect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x000B555D File Offset: 0x000B375D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo Clone()
		{
			return new ConnectEntityInfo(this);
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06004A38 RID: 19000 RVA: 0x000B5565 File Offset: 0x000B3765
		// (set) Token: 0x06004A39 RID: 19001 RVA: 0x000B556D File Offset: 0x000B376D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SrcEntityId
		{
			get
			{
				return this.srcEntityId_;
			}
			set
			{
				this.srcEntityId_ = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06004A3A RID: 19002 RVA: 0x000B5576 File Offset: 0x000B3776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConnectEntityTarget> TargetEntityInfos
		{
			get
			{
				return this.targetEntityInfos_;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x000B557E File Offset: 0x000B377E
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x000B5586 File Offset: 0x000B3786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConnect
		{
			get
			{
				return this.isConnect_;
			}
			set
			{
				this.isConnect_ = value;
			}
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x000B558F File Offset: 0x000B378F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectEntityInfo);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x000B55A0 File Offset: 0x000B37A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectEntityInfo other)
		{
			return other != null && (other == this || (this.SrcEntityId == other.SrcEntityId && this.targetEntityInfos_.Equals(other.targetEntityInfos_) && this.IsConnect == other.IsConnect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x000B5600 File Offset: 0x000B3800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SrcEntityId != 0L)
			{
				num ^= this.SrcEntityId.GetHashCode();
			}
			num ^= this.targetEntityInfos_.GetHashCode();
			if (this.IsConnect)
			{
				num ^= this.IsConnect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x000B5666 File Offset: 0x000B3866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x000B5673 File Offset: 0x000B3873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x000B567C File Offset: 0x000B387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SrcEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SrcEntityId);
			}
			this.targetEntityInfos_.WriteTo(ref output, ConnectEntityInfo._repeated_targetEntityInfos_codec);
			if (this.IsConnect)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsConnect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x000B56E8 File Offset: 0x000B38E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SrcEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SrcEntityId);
			}
			num += this.targetEntityInfos_.CalculateSize(ConnectEntityInfo._repeated_targetEntityInfos_codec);
			if (this.IsConnect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x000B5748 File Offset: 0x000B3948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SrcEntityId != 0L)
			{
				this.SrcEntityId = other.SrcEntityId;
			}
			this.targetEntityInfos_.Add(other.targetEntityInfos_);
			if (other.IsConnect)
			{
				this.IsConnect = other.IsConnect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x000B57A9 File Offset: 0x000B39A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x000B57B4 File Offset: 0x000B39B4
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsConnect = input.ReadBool();
						}
					}
					else
					{
						this.targetEntityInfos_.AddEntriesFrom(ref input, ConnectEntityInfo._repeated_targetEntityInfos_codec);
					}
				}
				else
				{
					this.SrcEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003068 RID: 12392
		private static readonly MessageParser<ConnectEntityInfo> _parser = new MessageParser<ConnectEntityInfo>(() => new ConnectEntityInfo());

		// Token: 0x04003069 RID: 12393
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400306A RID: 12394
		public const int SrcEntityIdFieldNumber = 1;

		// Token: 0x0400306B RID: 12395
		private long srcEntityId_;

		// Token: 0x0400306C RID: 12396
		public const int TargetEntityInfosFieldNumber = 2;

		// Token: 0x0400306D RID: 12397
		private static readonly FieldCodec<ConnectEntityTarget> _repeated_targetEntityInfos_codec = FieldCodec.ForMessage<ConnectEntityTarget>(18U, ConnectEntityTarget.Parser);

		// Token: 0x0400306E RID: 12398
		private readonly RepeatedField<ConnectEntityTarget> targetEntityInfos_ = new RepeatedField<ConnectEntityTarget>();

		// Token: 0x0400306F RID: 12399
		public const int IsConnectFieldNumber = 3;

		// Token: 0x04003070 RID: 12400
		private bool isConnect_;
	}
}
