using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001187 RID: 4487
	public sealed class SceneRoleInformation : IMessage<SceneRoleInformation>, IMessage, IEquatable<SceneRoleInformation>, IDeepCloneable<SceneRoleInformation>, IBufferMessage
	{
		// Token: 0x06017EAA RID: 97962 RVA: 0x0037947A File Offset: 0x0037767A
		[NullableContext(1)]
		public static SceneRoleInformation Create()
		{
			return new SceneRoleInformation();
		}

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x06017EAB RID: 97963 RVA: 0x00379481 File Offset: 0x00377681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneRoleInformation> Parser
		{
			get
			{
				return SceneRoleInformation._parser;
			}
		}

		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x06017EAC RID: 97964 RVA: 0x00379488 File Offset: 0x00377688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700505C RID: 20572
		// (get) Token: 0x06017EAD RID: 97965 RVA: 0x0037948B File Offset: 0x0037768B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneRoleInformation.Descriptor;
			}
		}

		// Token: 0x06017EAE RID: 97966 RVA: 0x00379492 File Offset: 0x00377692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoleInformation()
		{
		}

		// Token: 0x06017EAF RID: 97967 RVA: 0x0037949A File Offset: 0x0037769A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoleInformation(SceneRoleInformation other) : this()
		{
			this.roleId_ = other.roleId_;
			this.entityId_ = other.entityId_;
			this.onStageOutOfControl_ = other.onStageOutOfControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EB0 RID: 97968 RVA: 0x003794D7 File Offset: 0x003776D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneRoleInformation Clone()
		{
			return new SceneRoleInformation(this);
		}

		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x06017EB1 RID: 97969 RVA: 0x003794DF File Offset: 0x003776DF
		// (set) Token: 0x06017EB2 RID: 97970 RVA: 0x003794E7 File Offset: 0x003776E7
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

		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x06017EB3 RID: 97971 RVA: 0x003794F0 File Offset: 0x003776F0
		// (set) Token: 0x06017EB4 RID: 97972 RVA: 0x003794F8 File Offset: 0x003776F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x06017EB5 RID: 97973 RVA: 0x00379501 File Offset: 0x00377701
		// (set) Token: 0x06017EB6 RID: 97974 RVA: 0x00379509 File Offset: 0x00377709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OnStageOutOfControl
		{
			get
			{
				return this.onStageOutOfControl_;
			}
			set
			{
				this.onStageOutOfControl_ = value;
			}
		}

		// Token: 0x06017EB7 RID: 97975 RVA: 0x00379512 File Offset: 0x00377712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneRoleInformation);
		}

		// Token: 0x06017EB8 RID: 97976 RVA: 0x00379520 File Offset: 0x00377720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneRoleInformation other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.EntityId == other.EntityId && this.OnStageOutOfControl == other.OnStageOutOfControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EB9 RID: 97977 RVA: 0x0037957C File Offset: 0x0037777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OnStageOutOfControl)
			{
				num ^= this.OnStageOutOfControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017EBA RID: 97978 RVA: 0x003795ED File Offset: 0x003777ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EBB RID: 97979 RVA: 0x003795FA File Offset: 0x003777FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EBC RID: 97980 RVA: 0x00379604 File Offset: 0x00377804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.OnStageOutOfControl)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.OnStageOutOfControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017EBD RID: 97981 RVA: 0x00379678 File Offset: 0x00377878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OnStageOutOfControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017EBE RID: 97982 RVA: 0x003796DC File Offset: 0x003778DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneRoleInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OnStageOutOfControl)
			{
				this.OnStageOutOfControl = other.OnStageOutOfControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017EBF RID: 97983 RVA: 0x00379740 File Offset: 0x00377940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017EC0 RID: 97984 RVA: 0x0037974C File Offset: 0x0037794C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OnStageOutOfControl = input.ReadBool();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008DB4 RID: 36276
		private static readonly MessageParser<SceneRoleInformation> _parser = new MessageParser<SceneRoleInformation>(() => new SceneRoleInformation());

		// Token: 0x04008DB5 RID: 36277
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DB6 RID: 36278
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008DB7 RID: 36279
		private int roleId_;

		// Token: 0x04008DB8 RID: 36280
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04008DB9 RID: 36281
		private long entityId_;

		// Token: 0x04008DBA RID: 36282
		public const int OnStageOutOfControlFieldNumber = 3;

		// Token: 0x04008DBB RID: 36283
		private bool onStageOutOfControl_;
	}
}
