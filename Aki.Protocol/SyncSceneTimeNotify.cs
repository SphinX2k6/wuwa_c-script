using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001376 RID: 4982
	[NetMessage(EMessageId.SyncSceneTimeNotify)]
	public sealed class SyncSceneTimeNotify : IMessage<SyncSceneTimeNotify>, IMessage, IEquatable<SyncSceneTimeNotify>, IDeepCloneable<SyncSceneTimeNotify>, IBufferMessage
	{
		// Token: 0x0601A878 RID: 108664 RVA: 0x003DD861 File Offset: 0x003DBA61
		[NullableContext(1)]
		public static SyncSceneTimeNotify Create()
		{
			return new SyncSceneTimeNotify();
		}

		// Token: 0x170059D0 RID: 22992
		// (get) Token: 0x0601A879 RID: 108665 RVA: 0x003DD868 File Offset: 0x003DBA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059D1 RID: 22993
		// (get) Token: 0x0601A87A RID: 108666 RVA: 0x003DD86B File Offset: 0x003DBA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncSceneTimeNotify.Descriptor;
			}
		}

		// Token: 0x0601A87B RID: 108667 RVA: 0x003DD872 File Offset: 0x003DBA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncSceneTimeNotify()
		{
		}

		// Token: 0x0601A87C RID: 108668 RVA: 0x003DD87C File Offset: 0x003DBA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncSceneTimeNotify(SyncSceneTimeNotify other) : this()
		{
			this.timeInfo_ = ((other.timeInfo_ != null) ? other.timeInfo_.Clone() : null);
			this.showUi_ = other.showUi_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A87D RID: 108669 RVA: 0x003DD8C8 File Offset: 0x003DBAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncSceneTimeNotify Clone()
		{
			return new SyncSceneTimeNotify(this);
		}

		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x0601A87E RID: 108670 RVA: 0x003DD8D0 File Offset: 0x003DBAD0
		// (set) Token: 0x0601A87F RID: 108671 RVA: 0x003DD8D8 File Offset: 0x003DBAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTimeInfo TimeInfo
		{
			get
			{
				return this.timeInfo_;
			}
			set
			{
				this.timeInfo_ = value;
			}
		}

		// Token: 0x170059D3 RID: 22995
		// (get) Token: 0x0601A880 RID: 108672 RVA: 0x003DD8E1 File Offset: 0x003DBAE1
		// (set) Token: 0x0601A881 RID: 108673 RVA: 0x003DD8E9 File Offset: 0x003DBAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowUi
		{
			get
			{
				return this.showUi_;
			}
			set
			{
				this.showUi_ = value;
			}
		}

		// Token: 0x0601A882 RID: 108674 RVA: 0x003DD8F2 File Offset: 0x003DBAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncSceneTimeNotify);
		}

		// Token: 0x0601A883 RID: 108675 RVA: 0x003DD900 File Offset: 0x003DBB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncSceneTimeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TimeInfo, other.TimeInfo) && this.ShowUi == other.ShowUi && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A884 RID: 108676 RVA: 0x003DD950 File Offset: 0x003DBB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.timeInfo_ != null)
			{
				num ^= this.TimeInfo.GetHashCode();
			}
			if (this.ShowUi)
			{
				num ^= this.ShowUi.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A885 RID: 108677 RVA: 0x003DD9A5 File Offset: 0x003DBBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A886 RID: 108678 RVA: 0x003DD9B2 File Offset: 0x003DBBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A887 RID: 108679 RVA: 0x003DD9BC File Offset: 0x003DBBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.timeInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TimeInfo);
			}
			if (this.ShowUi)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.ShowUi);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A888 RID: 108680 RVA: 0x003DDA18 File Offset: 0x003DBC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.timeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TimeInfo);
			}
			if (this.ShowUi)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A889 RID: 108681 RVA: 0x003DDA64 File Offset: 0x003DBC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncSceneTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.timeInfo_ != null)
			{
				if (this.timeInfo_ == null)
				{
					this.TimeInfo = new SceneTimeInfo();
				}
				this.TimeInfo.MergeFrom(other.TimeInfo);
			}
			if (other.ShowUi)
			{
				this.ShowUi = other.ShowUi;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A88A RID: 108682 RVA: 0x003DDACC File Offset: 0x003DBCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A88B RID: 108683 RVA: 0x003DDAD8 File Offset: 0x003DBCD8
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
				if (num != 42U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ShowUi = input.ReadBool();
					}
				}
				else
				{
					if (this.timeInfo_ == null)
					{
						this.TimeInfo = new SceneTimeInfo();
					}
					input.ReadMessage(this.TimeInfo);
				}
			}
		}

		// Token: 0x04009B87 RID: 39815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B88 RID: 39816
		public const int TimeInfoFieldNumber = 5;

		// Token: 0x04009B89 RID: 39817
		private SceneTimeInfo timeInfo_;

		// Token: 0x04009B8A RID: 39818
		public const int ShowUiFieldNumber = 10;

		// Token: 0x04009B8B RID: 39819
		private bool showUi_;
	}
}
