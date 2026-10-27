using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F04 RID: 3844
	[NetMessage(EMessageId.RemovePreloadFlowsNotify)]
	public sealed class RemovePreloadFlowsNotify : IMessage<RemovePreloadFlowsNotify>, IMessage, IEquatable<RemovePreloadFlowsNotify>, IDeepCloneable<RemovePreloadFlowsNotify>, IBufferMessage
	{
		// Token: 0x0601496E RID: 84334 RVA: 0x002FD86B File Offset: 0x002FBA6B
		[NullableContext(1)]
		public static RemovePreloadFlowsNotify Create()
		{
			return new RemovePreloadFlowsNotify();
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x0601496F RID: 84335 RVA: 0x002FD872 File Offset: 0x002FBA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x06014970 RID: 84336 RVA: 0x002FD875 File Offset: 0x002FBA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemovePreloadFlowsNotify.Descriptor;
			}
		}

		// Token: 0x06014971 RID: 84337 RVA: 0x002FD87C File Offset: 0x002FBA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePreloadFlowsNotify()
		{
		}

		// Token: 0x06014972 RID: 84338 RVA: 0x002FD89C File Offset: 0x002FBA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePreloadFlowsNotify(RemovePreloadFlowsNotify other) : this()
		{
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this.flowListName_ = other.flowListName_;
			this.flowGuid_ = other.flowGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014973 RID: 84339 RVA: 0x002FD8F0 File Offset: 0x002FBAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePreloadFlowsNotify Clone()
		{
			return new RemovePreloadFlowsNotify(this);
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x06014974 RID: 84340 RVA: 0x002FD8F8 File Offset: 0x002FBAF8
		// (set) Token: 0x06014975 RID: 84341 RVA: 0x002FD900 File Offset: 0x002FBB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlowId
		{
			get
			{
				return this.flowId_;
			}
			set
			{
				this.flowId_ = value;
			}
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x06014976 RID: 84342 RVA: 0x002FD909 File Offset: 0x002FBB09
		// (set) Token: 0x06014977 RID: 84343 RVA: 0x002FD911 File Offset: 0x002FBB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
		{
			get
			{
				return this.stateId_;
			}
			set
			{
				this.stateId_ = value;
			}
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x06014978 RID: 84344 RVA: 0x002FD91A File Offset: 0x002FBB1A
		// (set) Token: 0x06014979 RID: 84345 RVA: 0x002FD922 File Offset: 0x002FBB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowListName
		{
			get
			{
				return this.flowListName_;
			}
			set
			{
				this.flowListName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x0601497A RID: 84346 RVA: 0x002FD935 File Offset: 0x002FBB35
		// (set) Token: 0x0601497B RID: 84347 RVA: 0x002FD93D File Offset: 0x002FBB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowGuid
		{
			get
			{
				return this.flowGuid_;
			}
			set
			{
				this.flowGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601497C RID: 84348 RVA: 0x002FD950 File Offset: 0x002FBB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemovePreloadFlowsNotify);
		}

		// Token: 0x0601497D RID: 84349 RVA: 0x002FD960 File Offset: 0x002FBB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemovePreloadFlowsNotify other)
		{
			return other != null && (other == this || (this.FlowId == other.FlowId && this.StateId == other.StateId && !(this.FlowListName != other.FlowListName) && !(this.FlowGuid != other.FlowGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601497E RID: 84350 RVA: 0x002FD9D4 File Offset: 0x002FBBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowGuid.Length != 0)
			{
				num ^= this.FlowGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601497F RID: 84351 RVA: 0x002FDA62 File Offset: 0x002FBC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014980 RID: 84352 RVA: 0x002FDA6F File Offset: 0x002FBC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014981 RID: 84353 RVA: 0x002FDA78 File Offset: 0x002FBC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowGuid.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.FlowGuid);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.StateId);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FlowId);
			}
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.FlowListName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014982 RID: 84354 RVA: 0x002FDB14 File Offset: 0x002FBD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014983 RID: 84355 RVA: 0x002FDBA4 File Offset: 0x002FBDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemovePreloadFlowsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowGuid.Length != 0)
			{
				this.FlowGuid = other.FlowGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014984 RID: 84356 RVA: 0x002FDC26 File Offset: 0x002FBE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014985 RID: 84357 RVA: 0x002FDC30 File Offset: 0x002FBE30
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
				if (num <= 88U)
				{
					if (num == 74U)
					{
						this.FlowGuid = input.ReadString();
						continue;
					}
					if (num == 88U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007CB0 RID: 31920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CB1 RID: 31921
		public const int FlowIdFieldNumber = 12;

		// Token: 0x04007CB2 RID: 31922
		private int flowId_;

		// Token: 0x04007CB3 RID: 31923
		public const int StateIdFieldNumber = 11;

		// Token: 0x04007CB4 RID: 31924
		private int stateId_;

		// Token: 0x04007CB5 RID: 31925
		public const int FlowListNameFieldNumber = 15;

		// Token: 0x04007CB6 RID: 31926
		private string flowListName_ = "";

		// Token: 0x04007CB7 RID: 31927
		public const int FlowGuidFieldNumber = 9;

		// Token: 0x04007CB8 RID: 31928
		private string flowGuid_ = "";
	}
}
