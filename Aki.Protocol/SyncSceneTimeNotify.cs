using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001309 RID: 4873
	[NetMessage(EMessageId.SyncSceneTimeNotify)]
	public sealed class SyncSceneTimeNotify : IMessage<SyncSceneTimeNotify>, IMessage, IEquatable<SyncSceneTimeNotify>, IDeepCloneable<SyncSceneTimeNotify>, IBufferMessage
	{
		// Token: 0x06019E68 RID: 106088 RVA: 0x003C35A9 File Offset: 0x003C17A9
		[NullableContext(1)]
		public static SyncSceneTimeNotify Create()
		{
			return new SyncSceneTimeNotify();
		}

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x06019E69 RID: 106089 RVA: 0x003C35B0 File Offset: 0x003C17B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x06019E6A RID: 106090 RVA: 0x003C35B3 File Offset: 0x003C17B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncSceneTimeNotify.Descriptor;
			}
		}

		// Token: 0x06019E6B RID: 106091 RVA: 0x003C35BA File Offset: 0x003C17BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncSceneTimeNotify()
		{
		}

		// Token: 0x06019E6C RID: 106092 RVA: 0x003C35C4 File Offset: 0x003C17C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncSceneTimeNotify(SyncSceneTimeNotify other) : this()
		{
			this.timeInfo_ = ((other.timeInfo_ != null) ? other.timeInfo_.Clone() : null);
			this.showUi_ = other.showUi_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E6D RID: 106093 RVA: 0x003C3610 File Offset: 0x003C1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncSceneTimeNotify Clone()
		{
			return new SyncSceneTimeNotify(this);
		}

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x06019E6E RID: 106094 RVA: 0x003C3618 File Offset: 0x003C1818
		// (set) Token: 0x06019E6F RID: 106095 RVA: 0x003C3620 File Offset: 0x003C1820
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

		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x06019E70 RID: 106096 RVA: 0x003C3629 File Offset: 0x003C1829
		// (set) Token: 0x06019E71 RID: 106097 RVA: 0x003C3631 File Offset: 0x003C1831
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

		// Token: 0x06019E72 RID: 106098 RVA: 0x003C363A File Offset: 0x003C183A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncSceneTimeNotify);
		}

		// Token: 0x06019E73 RID: 106099 RVA: 0x003C3648 File Offset: 0x003C1848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncSceneTimeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TimeInfo, other.TimeInfo) && this.ShowUi == other.ShowUi && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E74 RID: 106100 RVA: 0x003C3698 File Offset: 0x003C1898
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

		// Token: 0x06019E75 RID: 106101 RVA: 0x003C36ED File Offset: 0x003C18ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E76 RID: 106102 RVA: 0x003C36FA File Offset: 0x003C18FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E77 RID: 106103 RVA: 0x003C3704 File Offset: 0x003C1904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowUi)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowUi);
			}
			if (this.timeInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TimeInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E78 RID: 106104 RVA: 0x003C3760 File Offset: 0x003C1960
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

		// Token: 0x06019E79 RID: 106105 RVA: 0x003C37AC File Offset: 0x003C19AC
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

		// Token: 0x06019E7A RID: 106106 RVA: 0x003C3814 File Offset: 0x003C1A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E7B RID: 106107 RVA: 0x003C3820 File Offset: 0x003C1A20
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
				if (num != 16U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ShowUi = input.ReadBool();
				}
			}
		}

		// Token: 0x04009765 RID: 38757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009766 RID: 38758
		public const int TimeInfoFieldNumber = 5;

		// Token: 0x04009767 RID: 38759
		private SceneTimeInfo timeInfo_;

		// Token: 0x04009768 RID: 38760
		public const int ShowUiFieldNumber = 2;

		// Token: 0x04009769 RID: 38761
		private bool showUi_;
	}
}
