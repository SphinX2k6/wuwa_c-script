using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001591 RID: 5521
	[NetMessage(EMessageId.WorldLevelDownResponse)]
	public sealed class WorldLevelDownResponse : IMessage<WorldLevelDownResponse>, IMessage, IEquatable<WorldLevelDownResponse>, IDeepCloneable<WorldLevelDownResponse>, IBufferMessage
	{
		// Token: 0x0601D38A RID: 119690 RVA: 0x0043AC7E File Offset: 0x00438E7E
		[NullableContext(1)]
		public static WorldLevelDownResponse Create()
		{
			return new WorldLevelDownResponse();
		}

		// Token: 0x170062D7 RID: 25303
		// (get) Token: 0x0601D38B RID: 119691 RVA: 0x0043AC85 File Offset: 0x00438E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062D8 RID: 25304
		// (get) Token: 0x0601D38C RID: 119692 RVA: 0x0043AC88 File Offset: 0x00438E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldLevelDownResponse.Descriptor;
			}
		}

		// Token: 0x0601D38D RID: 119693 RVA: 0x0043AC8F File Offset: 0x00438E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownResponse()
		{
		}

		// Token: 0x0601D38E RID: 119694 RVA: 0x0043AC98 File Offset: 0x00438E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownResponse(WorldLevelDownResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.originWorldLevel_ = other.originWorldLevel_;
			this.curWorldLevel_ = other.curWorldLevel_;
			this.worldLevelTimeStamp_ = other.worldLevelTimeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D38F RID: 119695 RVA: 0x0043ACEC File Offset: 0x00438EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldLevelDownResponse Clone()
		{
			return new WorldLevelDownResponse(this);
		}

		// Token: 0x170062D9 RID: 25305
		// (get) Token: 0x0601D390 RID: 119696 RVA: 0x0043ACF4 File Offset: 0x00438EF4
		// (set) Token: 0x0601D391 RID: 119697 RVA: 0x0043ACFC File Offset: 0x00438EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170062DA RID: 25306
		// (get) Token: 0x0601D392 RID: 119698 RVA: 0x0043AD05 File Offset: 0x00438F05
		// (set) Token: 0x0601D393 RID: 119699 RVA: 0x0043AD0D File Offset: 0x00438F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginWorldLevel
		{
			get
			{
				return this.originWorldLevel_;
			}
			set
			{
				this.originWorldLevel_ = value;
			}
		}

		// Token: 0x170062DB RID: 25307
		// (get) Token: 0x0601D394 RID: 119700 RVA: 0x0043AD16 File Offset: 0x00438F16
		// (set) Token: 0x0601D395 RID: 119701 RVA: 0x0043AD1E File Offset: 0x00438F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWorldLevel
		{
			get
			{
				return this.curWorldLevel_;
			}
			set
			{
				this.curWorldLevel_ = value;
			}
		}

		// Token: 0x170062DC RID: 25308
		// (get) Token: 0x0601D396 RID: 119702 RVA: 0x0043AD27 File Offset: 0x00438F27
		// (set) Token: 0x0601D397 RID: 119703 RVA: 0x0043AD2F File Offset: 0x00438F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLevelTimeStamp
		{
			get
			{
				return this.worldLevelTimeStamp_;
			}
			set
			{
				this.worldLevelTimeStamp_ = value;
			}
		}

		// Token: 0x0601D398 RID: 119704 RVA: 0x0043AD38 File Offset: 0x00438F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldLevelDownResponse);
		}

		// Token: 0x0601D399 RID: 119705 RVA: 0x0043AD48 File Offset: 0x00438F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldLevelDownResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.OriginWorldLevel == other.OriginWorldLevel && this.CurWorldLevel == other.CurWorldLevel && this.WorldLevelTimeStamp == other.WorldLevelTimeStamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D39A RID: 119706 RVA: 0x0043ADB4 File Offset: 0x00438FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.OriginWorldLevel != 0)
			{
				num ^= this.OriginWorldLevel.GetHashCode();
			}
			if (this.CurWorldLevel != 0)
			{
				num ^= this.CurWorldLevel.GetHashCode();
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				num ^= this.WorldLevelTimeStamp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D39B RID: 119707 RVA: 0x0043AE44 File Offset: 0x00439044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D39C RID: 119708 RVA: 0x0043AE51 File Offset: 0x00439051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D39D RID: 119709 RVA: 0x0043AE5C File Offset: 0x0043905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurWorldLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurWorldLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.WorldLevelTimeStamp);
			}
			if (this.OriginWorldLevel != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.OriginWorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D39E RID: 119710 RVA: 0x0043AEEC File Offset: 0x004390EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.OriginWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginWorldLevel);
			}
			if (this.CurWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWorldLevel);
			}
			if (this.WorldLevelTimeStamp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLevelTimeStamp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D39F RID: 119711 RVA: 0x0043AF74 File Offset: 0x00439174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldLevelDownResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.OriginWorldLevel != 0)
			{
				this.OriginWorldLevel = other.OriginWorldLevel;
			}
			if (other.CurWorldLevel != 0)
			{
				this.CurWorldLevel = other.CurWorldLevel;
			}
			if (other.WorldLevelTimeStamp != 0)
			{
				this.WorldLevelTimeStamp = other.WorldLevelTimeStamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D3A0 RID: 119712 RVA: 0x0043AFEC File Offset: 0x004391EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D3A1 RID: 119713 RVA: 0x0043AFF8 File Offset: 0x004391F8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.CurWorldLevel = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.WorldLevelTimeStamp = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.OriginWorldLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A797 RID: 42903
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A798 RID: 42904
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A799 RID: 42905
		private ErrorCode errorCode_;

		// Token: 0x0400A79A RID: 42906
		public const int OriginWorldLevelFieldNumber = 15;

		// Token: 0x0400A79B RID: 42907
		private int originWorldLevel_;

		// Token: 0x0400A79C RID: 42908
		public const int CurWorldLevelFieldNumber = 1;

		// Token: 0x0400A79D RID: 42909
		private int curWorldLevel_;

		// Token: 0x0400A79E RID: 42910
		public const int WorldLevelTimeStampFieldNumber = 11;

		// Token: 0x0400A79F RID: 42911
		private int worldLevelTimeStamp_;
	}
}
