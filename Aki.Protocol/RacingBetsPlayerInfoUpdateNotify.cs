using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E70 RID: 3696
	[NetMessage(EMessageId.RacingBetsPlayerInfoUpdateNotify)]
	public sealed class RacingBetsPlayerInfoUpdateNotify : IMessage<RacingBetsPlayerInfoUpdateNotify>, IMessage, IEquatable<RacingBetsPlayerInfoUpdateNotify>, IDeepCloneable<RacingBetsPlayerInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06013DB5 RID: 81333 RVA: 0x002E45E7 File Offset: 0x002E27E7
		[NullableContext(1)]
		public static RacingBetsPlayerInfoUpdateNotify Create()
		{
			return new RacingBetsPlayerInfoUpdateNotify();
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x06013DB6 RID: 81334 RVA: 0x002E45EE File Offset: 0x002E27EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x06013DB7 RID: 81335 RVA: 0x002E45F1 File Offset: 0x002E27F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPlayerInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06013DB8 RID: 81336 RVA: 0x002E45F8 File Offset: 0x002E27F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoUpdateNotify()
		{
		}

		// Token: 0x06013DB9 RID: 81337 RVA: 0x002E4600 File Offset: 0x002E2800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoUpdateNotify(RacingBetsPlayerInfoUpdateNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DBA RID: 81338 RVA: 0x002E4635 File Offset: 0x002E2835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoUpdateNotify Clone()
		{
			return new RacingBetsPlayerInfoUpdateNotify(this);
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x06013DBB RID: 81339 RVA: 0x002E463D File Offset: 0x002E283D
		// (set) Token: 0x06013DBC RID: 81340 RVA: 0x002E4645 File Offset: 0x002E2845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06013DBD RID: 81341 RVA: 0x002E464E File Offset: 0x002E284E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPlayerInfoUpdateNotify);
		}

		// Token: 0x06013DBE RID: 81342 RVA: 0x002E465C File Offset: 0x002E285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPlayerInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DBF RID: 81343 RVA: 0x002E4690 File Offset: 0x002E2890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013DC0 RID: 81344 RVA: 0x002E46CC File Offset: 0x002E28CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DC1 RID: 81345 RVA: 0x002E46D9 File Offset: 0x002E28D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DC2 RID: 81346 RVA: 0x002E46E2 File Offset: 0x002E28E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013DC3 RID: 81347 RVA: 0x002E4714 File Offset: 0x002E2914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013DC4 RID: 81348 RVA: 0x002E4754 File Offset: 0x002E2954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsPlayerInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new RacingBetPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013DC5 RID: 81349 RVA: 0x002E47A8 File Offset: 0x002E29A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DC6 RID: 81350 RVA: 0x002E47B4 File Offset: 0x002E29B4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.playerInfo_ == null)
					{
						this.PlayerInfo = new RacingBetPlayerInfo();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x04007976 RID: 31094
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007977 RID: 31095
		public const int PlayerInfoFieldNumber = 8;

		// Token: 0x04007978 RID: 31096
		private RacingBetPlayerInfo playerInfo_;
	}
}
